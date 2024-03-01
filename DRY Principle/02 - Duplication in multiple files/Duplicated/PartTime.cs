using System;

namespace DRY_Principle.Multiple_File
{
    public class PartTimeEmployee : Employee
    {
        public override int CalculateBonus()
        {
            return base.CalculateBonus() + 500;
        }
    }
}
