using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak4.Generators
{
    class RandomGenerator : INumberGenerator
    {
        int n;
        double stdDev;
        int[] num;
        public RandomGenerator(int n, int stdDev)
        {
            this.n = n;
            this.stdDev = stdDev;
            num = new int[n];
        }
        public int[] Generate()
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                double u1 = rand.NextDouble();
                double u2 = rand.NextDouble();
                double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                             Math.Sin(2.0 * Math.PI * u2);
                double randNormal = stdDev * randStdNormal;
                num[i] = (int) Math.Round(randNormal);
            }
            return num;
            
        }
    }
}
