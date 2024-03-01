-- Create the Employees table
CREATE TABLE Employees (
    EmployeeID SERIAL PRIMARY KEY,
    Name VARCHAR(100),
    BasicSalary INT,
    Bonus INT
);

-- Populate the Employees table with sample data
INSERT INTO Employees (Name, BasicSalary, Bonus) VALUES
('John', 50000, 2000),
('Sarah', 60000, 3000),
('Mike', 55000, 2500);

-- Create the materialized view
CREATE MATERIALIZED VIEW EmployeeTotalSalary AS
SELECT 
    EmployeeID,
    Name,
    BasicSalary,
    Bonus,
    (BasicSalary + Bonus) AS TotalSalary
FROM Employees;
