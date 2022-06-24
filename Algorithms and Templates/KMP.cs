using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6.Algorithms
{
    internal class kmp
    {
        public int[] lps(string pat)
        {
            int[] lps = new int[pat.Length];
            int j = 0;
            for (int i = 1; i < pat.Length; i++)
            {
                while (j > 0 && pat[i] != pat[j])
                {
                    j = Math.Max(0, lps[j - 1]);
                }
                j += pat[i] == pat[j] ? 1 : 0;
                lps[i] = j;
            }
            return lps;
        }
        public int[] LPSArray(string pat)
        {
            int[] lps = new int[pat.Length];
            int M = lps.Length;
            int j = 0;
            int i = 1;
            lps[0] = 0;

            while (i < M)
            {
                if (pat[i] == pat[j])
                {
                    j++;
                    lps[i] = j;
                    i++;
                }
                else
                {
                    if (j != 0)
                    {
                        j = lps[j - 1];
                    }
                    else
                    {
                        lps[i] = j;
                        i++;
                    }
                }
            }

            return lps;
        }
    }
}
