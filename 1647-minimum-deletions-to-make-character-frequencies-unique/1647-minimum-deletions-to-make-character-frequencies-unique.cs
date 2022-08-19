public class Solution {
    public int MinDeletions(string s) {
            var f = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                f[s[i] - 'a']++;
            }
            var h = new HashSet<int>();
            int res = 0;
            for (int i = 0; i < 26; i++)
            {
                if (!h.Contains(f[i]))
                {
                    h.Add(f[i]);
                }
                else
                {
                    while (f[i]>0 && h.Contains(f[i]))
                    {
                        res++;
                        f[i]--;
                    }
                    h.Add(f[i]);
                }
            }
            return res;
    }
}