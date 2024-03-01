using System;

namespace DRY_Principle.Single_File
{
    class Program
    {
        static void Main1(string[] args)
        {
            // Calculate salary for full-time employee
            int fullTimeSalary = CalculateFullTimeEmployeeSalary(40, 25);
            Console.WriteLine("Full-time employee salary: $" + fullTimeSalary);

            // Calculate salary for part-time employee
            int partTimeSalary = CalculatePartTimeEmployeeSalary(20, 15);
            Console.WriteLine("Part-time employee salary: $" + partTimeSalary);
        }

        static int CalculateFullTimeEmployeeSalary(int hoursWorked, int hourlyRate)
        {
            // Step 1: Calculate regular pay
            int regularPay = hoursWorked * hourlyRate;

            // Step 2: Calculate overtime pay
            int overtimeHours = Math.Max(0, hoursWorked - 40);
            int overtimePay = overtimeHours * hourlyRate * 2;

            // Step 3: Calculate total salary
            int totalSalary = regularPay + overtimePay;

            // Step 4: Deduct taxes
            int taxedSalary = totalSalary - (int)(totalSalary * 0.1); // 10% tax deduction

            return taxedSalary;
        }

        static int CalculatePartTimeEmployeeSalary(int hoursWorked, int hourlyRate)
        {
            // Step 1: Calculate regular pay
            int regularPay = hoursWorked * hourlyRate;

            // Step 2: No overtime for part-time employees, so set overtime pay to 0

            // Step 3: Calculate total salary
            int totalSalary = regularPay;

            // Step 4: Deduct taxes
            int taxedSalary = totalSalary - (int)(totalSalary * 0.1); // 10% tax deduction

            return taxedSalary;
        }
    }
}