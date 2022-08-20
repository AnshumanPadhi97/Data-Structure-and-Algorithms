using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6.OA_Prep
{
    internal class Equal_Array
    {
        public int check(int[] a, int[] b)
        {
            //1 3 2 4
            //4 2 4
            var sum1 = a.Sum();
            var sum2 = b.Sum();
            if (sum1 != sum2) return -1;

            int i = 0, j = 0, res = 0;
            while (i < a.Length)
            {
                res++;
                var suma = a[i++];
                var sumb = b[j++];
                while (suma != sumb)
                {
                    if (suma < sumb)
                    {
                        suma += a[i++];
                    }
                    else
                    {
                        sumb += b[j++];
                    }
                }
            }
            return res;
        }
    }
}
