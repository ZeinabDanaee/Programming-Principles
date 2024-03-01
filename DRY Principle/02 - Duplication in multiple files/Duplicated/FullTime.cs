using System;

namespace DRY_Principle.Multiple_File
{
    public class FullTimeEmployee : Employee
    {
        public override int CalculateBonus()
        {
            return base.CalculateBonus() + 1000;
        }
    }
}
