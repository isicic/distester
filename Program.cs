using System;
using zadatak4.Generators;
using zadatak4.Percentile;

namespace zadatak4
{
    class Program
    {
        static void Main(string[] args)
        {
            DistributionTester dt = new DistributionTester(new RandomGenerator(20, 5), new Interpolation());
            dt.Test();

            Console.ReadLine();
        }
    }
}