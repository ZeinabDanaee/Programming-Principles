using System;

public class FullTimeEmployee : Employee
{
    public override int CalculateBonus()
    {
        return base.CalculateBonus() + 1000;
    }
}
