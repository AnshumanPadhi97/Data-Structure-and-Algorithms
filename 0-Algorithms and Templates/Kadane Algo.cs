using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6.Algorithms_and_Templates
{
    //Largest Sum Contiguous Subarray
    internal class Kadane_Algo
    {
        public int kadane(int[] a)
        {
            var res = int.MinValue;
            var curr = 0;

            for (int i = 0; i < a.Length; i++)
            {
                curr += a[i];
                res = Math.Max(res, curr);
                if (curr < 0) curr = 0;
            }

            return res;
        }
    }
}
