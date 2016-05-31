using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak4.Generators
{
    class Fibonacci : INumberGenerator
    {
        int n;
        int[] num;
        public Fibonacci(int n)
        {
            this.n = n;
            num = new int[n];
        }
        public int[] Generate()
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                num[i] = a;
            }
            return num;
        }
    }
}
