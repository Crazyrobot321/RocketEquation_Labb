using System;
using System.Collections.Generic;
using System.Text;
using AdventOfCode.Common;

namespace RocketEquation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Path.Combine(AppContext.BaseDirectory, "input.txt");
            var text = File.ReadAllText(input);
            var fuel = Input.Numbers(text);

            var calculator = new FuelCalculator();
            Console.WriteLine($"Del 1: {calculator.SumFuelForAllModules(fuel)}");
            Console.WriteLine($"Del 2: {calculator.SumTotalFuelForAllModules(fuel)}");
        }
    }
}
