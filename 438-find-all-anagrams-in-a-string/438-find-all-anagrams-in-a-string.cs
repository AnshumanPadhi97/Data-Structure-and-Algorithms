public class Solution {
        public IList<int> FindAnagrams(string s, string p)
        {
            var res = new List<int>();

            if (p.Length > s.Length) return res;

            var cf1 = new int[26];
            for (int k = 0; k < p.Length; k++)
            {
                cf1[p[k] - 'a']++;
            }
            var cf2 = new int[26];
            var c = s.Substring(0, p.Length);
            for (int k = 0; k < p.Length; k++)
            {
                cf2[c[k] - 'a']++;
            }
            if (check(cf1, cf2))
            {
                res.Add(0);
            }

            for (int i = p.Length; i < s.Length; i++)
            {
                cf2[s[i] - 'a']++;
                cf2[s[i - p.Length] - 'a']--;
                if (check(cf1, cf2))
                {
                    res.Add(i - p.Length + 1);
                }
            }

            return res;
        }
        public bool check(int[] a, int[] b)
        {
            for (int i = 0; i < 26; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }
}