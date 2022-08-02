public class Solution {
    public bool WordPattern(string pattern, string s) {
        var d = new Dictionary<char,string>();
        var d1 = new Dictionary<string,char>();
        var c = s.Split(' ');
        if(pattern.Length!=c.Length)return false;
        for(int i=0;i<pattern.Length;i++){
            if(!d.ContainsKey(pattern[i])){
                d.Add(pattern[i],c[i]);
            }
            if(!d1.ContainsKey(c[i])){
                d1.Add(c[i],pattern[i]);
            }
            var a = d[pattern[i]];
            var p = d1[c[i]];
            if(a==c[i] && p==pattern[i])continue;
            else return false;
        }
        return true;
    }
}