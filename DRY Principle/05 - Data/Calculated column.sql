CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    Name VARCHAR(100),
    BasicSalary INT,
    Bonus INT, -- Implicit Calculated column
    TotalSalary AS (BasicSalary + Bonus) -- Explicit Calculated column
);