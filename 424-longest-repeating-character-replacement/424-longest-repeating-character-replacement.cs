public class Solution {
    public int CharacterReplacement(string s, int k) {
            var f = new int[26];
            int i = 0, j = 0, res = 0, curr = 0, l = s.Length;
            while (j < l)
            {
                curr = Math.Max(curr, ++f[s[j++] - 'A']);
                while (j - i - curr > k)
                {
                    f[s[i++] - 'A']--;
                }
                res = Math.Max(res, j - i);
            }
            return res;
    }
}