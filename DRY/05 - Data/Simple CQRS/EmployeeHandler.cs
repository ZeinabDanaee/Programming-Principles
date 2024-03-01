public class EmployeeCommandHandler
{
    public void Handle(EmployeeCommand command)
    {
        // Command handling logic: validation, business rules, and data persistence
        Console.WriteLine($"Handling command for EmployeeID {command.EmployeeID}");
    }
}

public class EmployeeQueryHandler
{
    public EmployeeQueryResult Handle(int employeeID)
    {
        // Query handling logic: data retrieval and projection
        Console.WriteLine($"Handling query for EmployeeID {employeeID}");
        return new EmployeeQueryResult
        {
            EmployeeID = employeeID,
            // Populate with data from the database or other sources
            Name = "John Doe",
            TotalSalary = 50000
        };
    }
}
