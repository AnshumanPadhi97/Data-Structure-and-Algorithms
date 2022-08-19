public class Solution {
    public int MinMovesToMakePalindrome(string s) {
            int res = 0;
            while (s.Length > 0)
            {
                var ind = s.IndexOf(s[s.Length - 1]);
                if (ind == s.Length - 1)
                {
                    res += ind / 2;
                }
                else
                {
                    res += ind;
                    s = s.Substring(0, ind) + s.Substring(ind + 1);
                }
                s = s.Substring(0, s.Length - 1);
            }
            return res;
    }
}