using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6.OA_Prep
{
    internal class GarbageCollector
    {
        public int check(int[] a, string[] b)
        {
            var ls = new List<int[]>();

            for (int i = 0; i < a.Length; i++)
            {
                int c = b[i].Length;
                var d = new int[26];
                for (int j = 0; j < c; j++)
                {
                    d[b[i][j] - 'A']++;
                }
                ls.Add(d);
            }
            int res = 0;

            foreach (var item in "PGM")
            {
                int cur = 0, max = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (ls[i][item - 'A'] > 0)
                    {
                        cur += 2 * a[i];
                        cur += ls[i][item - 'A'];
                        max = Math.Max(max, cur);
                    }
                    else
                    {
                        cur += 2 * a[i];
                    }
                }
                res = Math.Max(res, max);
            }

            return res;
        }
    }
}
