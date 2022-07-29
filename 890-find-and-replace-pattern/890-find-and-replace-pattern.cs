public class Solution {
    public IList<string> FindAndReplacePattern(string[] words, string pattern)
    {
        var res= new List<string>();
        foreach (var word in words)
        {
            if (match(word, pattern))
            {
                res.Add(word);
            }
        }
        return res;
    }
    bool match(string word,string pattern)
    {
        var d1 = new Dictionary<char, char>();
        var d2 = new Dictionary<char, char>();
        for (int i = 0; i < word.Length; i++)
        {
            var w = word[i];
            var p = pattern[i];
            if (!d1.ContainsKey(w)) { d1.Add(w, p); }
            if (!d2.ContainsKey(p)) { d2.Add(p, w); }
            if (d1[w] != p || d2[p] != w) { return false; }
        }
        return true;
    }
}