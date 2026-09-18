
public class FuelCalculator
{
    public int SumFuelForAllModules(int[] masses)
    {
        return masses.Sum(FuelForMass);
    }
    public int FuelForMass(int mass)
    {
        return mass / 3 - 2;
    }
    public int TotalFuelForMass(int mass)
    {
        int fuel = FuelForMass(mass);
        if (fuel <= 0) 
            return 0;
        return fuel + TotalFuelForMass(fuel);
    }
    public int SumTotalFuelForAllModules(int[] masses)
    {
        return masses.Sum(TotalFuelForMass);
    }
}