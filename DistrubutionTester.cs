using System;
using zadatak4.Generators;
using zadatak4.Percentile;

namespace zadatak4
{
    class DistributionTester
    {
        private INumberGenerator numGen;
        private IPercentile perCal;
        public DistributionTester(INumberGenerator gen, IPercentile cal)
        {
            numGen = gen;
            perCal = cal;
        }

        public void Test()
        {
            int[] numbers = numGen.Generate();
            Console.Write("Generiran niz: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            for (int i = 10; i <= 90; i += 10)
            {
                Console.Write("\n" + i + ". percentil: " + perCal.PercentileCalc(numbers, i));
            }
        }

    }
}
