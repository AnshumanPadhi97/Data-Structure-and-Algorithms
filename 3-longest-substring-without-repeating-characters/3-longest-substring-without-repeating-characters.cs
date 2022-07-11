public class Solution {
    public int LengthOfLongestSubstring(string s) {
        string t ="";
        int i=0,j=0,res=0,l=s.Length;
        while(j<l){
            if(!t.Contains(s[j])){
                t+=s[j];
                res=Math.Max(res,t.Length);
            }else{
                var ind = t.IndexOf(s[j]);
                t=t.Substring(ind+1);
                t+=s[j];
            }
            j++;
        }
        return res;
    }
}