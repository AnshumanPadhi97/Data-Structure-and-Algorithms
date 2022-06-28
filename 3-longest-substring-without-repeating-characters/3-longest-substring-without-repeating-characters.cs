public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var res=0;
        var temp = "";
        for(int i=0;i<s.Length;i++){
            if(!temp.Contains(s[i])){
                temp+=s[i];
                res=Math.Max(res,temp.Length);
            }else{
                var ind = temp.IndexOf(s[i]);
                temp=temp.Substring(ind+1);
                temp+=s[i];
            }
        }
        return res;
    }
}