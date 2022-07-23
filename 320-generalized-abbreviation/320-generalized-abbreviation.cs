public class Solution {
        IList<string> res = new List<string>();
        public IList<string> GenerateAbbreviations(string word)
        {
            h(word, "", 0, 0);
            return res;
        }
        public void h(string word,string temp,int i,int k)
        {
            if (i == word.Length)
            {
                if (k != 0) temp+= k;
                res.Add(new string(temp));
                return;
            }
            // choice 1: abbreviate
            h(word, temp, i + 1, k + 1);
            // choice 2: don't abbreviate, insert the character
            if (k != 0)
            {
                temp += k;
            }
            // choose
            temp += word[i];
            // explore
            h(word, temp, i + 1, 0);
            // un-choose
            temp = temp.Substring(0, temp.Length - 1);
        }
}