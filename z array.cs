using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6
{
    internal class z_array
    {
        public int[] z(string pat)
        {
            int[] z = new int[pat.Length];
            int l = 0, r = 0;

            for (int i = 1; i < pat.Length; i++)
            {
                z[i] = i > r ? 0 : Math.Min(r - i, z[i - l]);
                while (i + z[i] < pat.Length && pat[z[i]] == pat[z[i] + i])
                {
                    ++z[i];
                }
                if (z[i] + i > r)
                {
                    l = i;
                    r = z[i] + i;
                }
            }
            return z;
        }
    }
}
