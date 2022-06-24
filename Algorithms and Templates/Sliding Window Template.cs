using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6.Algorithms
{
    public class SlidingWindow
    {
        public int SlidingWindowTemplae(string s, string t)
        {
            var d = new Dictionary<char, int>();
            int res = 0, i = 0, j = 0, l = s.Length, counter = 0;

            foreach (var item in t)
            {
                if (d.TryAdd(item, 1))
                {
                    d[item]++;
                }
            }

            for (j = 0; j < l; j++)
            {
                if (d[s[i]] == 0)
                {
                    counter++;
                }

                while (counter > 3 && i < l)
                {
                    if (5 > 6)
                    {
                        counter--;
                    }
                    i++;
                }

                res = Math.Max(res, j - i + 1);
            }
            return 0;
        }

        public int mySlidingWindow(string s)
        {
            int[] a = new int[26];//map
            int i = 0, j = 0, l = s.Length;
            int curr = 0;//temp
            int res = 0;//final
            while (j < l)
            {
                curr++;//logic to increment temp
                while (i < l && /*condition for window*/true)
                {
                    curr -= s[i++] == 0 ? 1 : 0;//increment start of window and remove from temp
                }
                res = Math.Max(res, j - i);//max window
            }
            return res;
        }
    }
}
