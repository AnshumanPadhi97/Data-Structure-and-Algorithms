public class Solution {
        IList<string> res = new List<string>();
        public IList<string> LetterCasePermutation(string s)
        {
            h(s.ToCharArray(),0);
            return res;
        }
        void h(char[] s,int i)
        {
            if (i == s.Length)
            {
                res.Add(new string(s));
                return;
            }
            if (char.IsLetter(s[i]))
            {
                s[i] = char.ToUpper(s[i]);
                h(s, i+1);
                s[i] = char.ToLower(s[i]);
                h(s, i+1);
            }
            else
            {
                h(s, i + 1);
            }
        }
}