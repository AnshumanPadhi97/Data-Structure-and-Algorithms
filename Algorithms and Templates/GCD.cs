using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6.Algorithms_and_Templates
{
    internal class GCD
    {
        int gcd(int a, int b)
        {
            if (a == 0)
                return b;

            return gcd(b % a, a);
        }
    }
}
