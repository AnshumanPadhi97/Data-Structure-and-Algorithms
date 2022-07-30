public class Solution {
        public IList<string> WordSubsets(string[] words1, string[] words2)
        {
            var res = new List<string>();
            var bmax = count("");
            int i = 0;
            foreach (var item in words2)
            {
                var bcount = count(item);
                for (i = 0; i < 26; i++)
                {
                    bmax[i] = Math.Max(bmax[i], bcount[i]);
                }
            }
            i = 0;
            foreach (var item in words1)
            {
                var a = count(item);
                for (i = 0; i < 26; i++)
                {
                    if (a[i] < bmax[i])
                    {
                        break;
                    }
                }
                if (i == 26) res.Add(item);
            }
            return res;
        }
        public int[] count(string s)
        {
            var res = new int[26];
            foreach (var item in s)
            {
                res[item -'a']++;
            }
            return res;
        }
}