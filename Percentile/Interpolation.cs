using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak4.Percentile
{
    class Interpolation : IPercentile
    {
        public int PercentileCalc(int[] num, int p)
        {
            Array.Sort(num);
            int N = num.Length;
            double n = (N - 1) * p/100 + 1;
            
            if (n == 1d) return num[0];
            else if (n == N) return num[N - 1];
            else
            {
                int k = (int)n;
                double d = n - k;
                return (int) (num[k - 1] + d * (num[k] - num[k - 1]));
            }
        }
    }
}
