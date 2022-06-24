using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6.Algorithms
{
    internal class prime_factors
    {
        static void primeFactors(int n)
        {
            int c = 2;
            while (n > 1)
            {
                if (n % c == 0)
                {
                    Console.Write(c + " ");
                    n /= c;
                }
                else
                    c++;
            }
        }
    }
}
