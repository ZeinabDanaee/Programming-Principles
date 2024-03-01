using System;

namespace DRY_Principle.Data_Duplication
{
    class Program
    {
        static void Main1(string[] args)
        {
            var commandHandler = new EmployeeCommandHandler();
            var queryHandler = new EmployeeQueryHandler();

            var command = new EmployeeCommand { 
                EmployeeID = 123, 
                Name = "John", 
                BasicSalary = 50000 
            };
            commandHandler.Handle(command);

            var employeeID = 456;
            var queryResult = queryHandler.Handle(employeeID);
            Console.WriteLine($"Employee {queryResult.Name}'s total salary: {queryResult.TotalSalary}");
        }
    }

}
