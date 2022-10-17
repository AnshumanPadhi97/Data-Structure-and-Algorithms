public class Solution {
    public bool CheckIfPangram(string s) {
        var a = new HashSet<int>();
        for(int i=0;i<s.Length;i++){
            a.Add(s[i]);
        }
        return a.Count == 26;
    }
}