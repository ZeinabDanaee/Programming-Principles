using System;

namespace DRY_Principle.Not_Duplicated
{
    public class PartTimeEmployee : Employee
    {
        public override int CalculateBonus()
        {
            return base.CalculateBonus() + 1000;
        }
    }
}