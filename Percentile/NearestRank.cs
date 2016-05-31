using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak4.Percentile
{
    class NearestRank : IPercentile
    {
        public int PercentileCalc(int[] num, int p)
        {
            return num[(int) (p*num.Length + 0.5)];
        }
    }
}
