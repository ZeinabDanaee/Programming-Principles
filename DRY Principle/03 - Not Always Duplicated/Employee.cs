using System;

namespace DRY_Principle.Not_Duplicated
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public virtual int CalculateBonus()
        {
            return Salary * 5 / 100; // 5% of salary
        }
    }
}