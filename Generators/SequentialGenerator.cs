using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak4.Generators
{
    class SequentialGenerator : INumberGenerator
    {
        int min, max, step, n, el;
        int[] num;
        public SequentialGenerator(int min, int max, int step)
        {
            this.min = min;
            this.max = max;
            this.step = step;
            n = Math.Abs((max - min)) / step;
            num = new int[n];
        }
        public int[] Generate()
        {
            for (int i = 0; i <= n; i++)
            {
                num[i] = min + step*i;
            }
            return num;
        }
    }
}
