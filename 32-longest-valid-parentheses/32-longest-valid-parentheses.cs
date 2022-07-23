public class Solution {
    public int LongestValidParentheses(string s) {
            int l = 0, r = 0, res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(') l++;
                else r++;
                if (l == r)
                {
                    res = Math.Max(res, 2 * r);
                }
                if (r > l)
                {
                    l = r = 0;
                }
            }
            l=r=0;  
            for (int i = s.Length-1; i >=0; i--)
            {
                if (s[i] == ')') r++;
                else l++;
                if (l == r)
                {
                    res = Math.Max(res, 2 * r);
                }
                if (l > r) l = r = 0;
            }
            return res;
    }
}