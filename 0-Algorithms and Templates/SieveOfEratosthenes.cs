using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6.Algorithms
{
    internal class SieveOfEratosthenes
    {
        static int[] Primes = new int[500001];
        public void SieveOfEratosthenesAlgo(int n)
        {
            Primes[0] = 1;
            for (int i = 3; i * i <= n; i += 2)
            {
                if (Primes[i / 2] == 0)
                {
                    for (int j = 3 * i; j <= n; j += 2 * i)
                        Primes[j / 2] = 1;
                }
            }
        }
    }
}
