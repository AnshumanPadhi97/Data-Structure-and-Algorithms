public class Solution {
    public void swap(char[] s,int i,int j)
    {
        var a = s[i];
        s[i] = s[j];
        s[j] = a;
    }
    public int MinMovesToMakePalindrome(string s) {
            int n = s.Length;
            int res = 0;
            var a = s.ToCharArray();

            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                int l = left, r = right;
                while (a[l] != a[r])
                {
                    r--;
                }
                if (l == r)
                {
                    swap(a, r, r + 1);
                    res++;
                    continue;
                }
                else
                {
                    while (r < right)
                    {
                        swap(a, r, r + 1);
                        res++;
                        r++;
                    }
                }
                left++;
                right--;
            }
            return res;
    }
}