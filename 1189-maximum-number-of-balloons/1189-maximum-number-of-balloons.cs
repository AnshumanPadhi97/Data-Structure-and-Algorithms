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
            return Math.Min(Math.Min(Math.Min(a, b), n), Math.Min(l / 2, o / 2));
    }
}