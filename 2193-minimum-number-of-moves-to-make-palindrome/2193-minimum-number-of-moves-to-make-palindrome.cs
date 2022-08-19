public class Solution {
    public int MinMovesToMakePalindrome(string s) {
            int res = 0;
            while (s.Length > 0)
            {
                int i = s.IndexOf(s[s.Length - 1]);
                if (i == s.Length-1)
                {
                    res += i / 2;
                }
                else
                {
                    res += i;
                    s = s.Substring(0, i) + s.Substring(i + 1);
                }
                s = s.Substring(0, s.Length - 1);
            }
            return res;
    }
}