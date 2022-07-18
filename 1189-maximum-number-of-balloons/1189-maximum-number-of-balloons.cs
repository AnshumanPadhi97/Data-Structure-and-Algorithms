public class Solution {
    public int MaxNumberOfBalloons(string text) {
        int b = 0, a = 0, l = 0, o = 0, n = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'b') b++;
                if (text[i] == 'a') a++;
                if (text[i] == 'l') l++;
                if (text[i] == 'o') o++;
                if (text[i] == 'n') n++;
            }
            int res = 0;
            while (true)
            {
                if (b > 0)
                {
                    b--;
                }
                else
                {
                    break;
                }
                if (a > 0)
                {
                    a--;
                }
                else
                {
                    break;
                }
                if (l > 0)
                {
                    l--;
                    if(l==0)break;
                    l--;
                }
                else
                {
                    break;
                }
                if (o > 0)
                {
                    o--;
                    if(o==0)break;
                    o--;
                }
                else
                {
                    break;
                }
                if (n > 0)
                {
                    n--;
                }
                else
                {
                    break;
                }
                res++;
            }
            return res;
    }
}