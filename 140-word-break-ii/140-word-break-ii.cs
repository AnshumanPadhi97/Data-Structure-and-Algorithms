public class Solution {
    public IList<string> WordBreak(string s, IList<string> wordDict) {
        return DFS(s, wordDict, new Dictionary<string, List<string>>());
    }
    List<string> DFS(string s, IList<string> wordDict, Dictionary<string, List<string>> hash)       {
        
        if(hash.ContainsKey(s))
            return hash[s];
        
        List<string> res = new List<string>();
        
        if(string.IsNullOrWhiteSpace(s)) {
            res.Add("");
            return res;
        }
        
        foreach(string word in wordDict) {
            if(s.StartsWith(word)) {
                
                string right = s.Substring(word.Length);
                
                var ls = DFS(right, wordDict, hash);
                
                foreach(var item in ls) {
                    string str = string.IsNullOrWhiteSpace(item) ? "": " "+ item;
                    res.Add(word+str);
                }
            }
        }
        
        hash.Add(s, res);
        return res;
    }
}