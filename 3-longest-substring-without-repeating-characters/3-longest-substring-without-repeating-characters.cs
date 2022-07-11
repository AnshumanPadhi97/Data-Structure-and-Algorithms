public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var d = new Dictionary<char,int>();
        int i=0,j=0,res=0,l=s.Length;
        while(j<l){
            if(d.ContainsKey(s[j])){
                i=Math.Max(i,d[s[j]]);
                d.Remove(s[j]);
            }
            res=Math.Max(res,j-i+1);
            d.Add(s[j],j+1);
            j++;
        }
        return res;
    }
}