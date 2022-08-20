using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6._01_OA_Prep
{
    internal class SlicesToSortArr
    {
        public int check(int[] a)
        {
            int n = a.Length;
            int[] b = new int[n];
            b[n - 1] = a[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                b[i] = Math.Min(b[i + 1], a[i]);
            }
            int res = 0;
            int max = int.MinValue;
            for (int i = 0; i < n - 1; i++)
            {
                max = Math.Max(max, a[i]);
                if (max <= b[i + 1]) res++;
            }
            return res + 1;
        }
    }
}
