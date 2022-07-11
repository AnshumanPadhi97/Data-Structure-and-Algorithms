public class Solution {
    public int LengthOfLongestSubstringTwoDistinct(string s) {
        var d = new Dictionary<char,int>();
        int i=0,j=0,l=s.Length,res=0;
        while(j<l){
            if(!d.ContainsKey(s[j])){
                d.Add(s[j],0);
            }
            d[s[j]]++;
            j++;
            while(i<l && d.Count>2){
                d[s[i]]--;
                if(d[s[i]]==0){
                    d.Remove(s[i]);
                }
                i++;
            }
            res=Math.Max(res,j-i);
        }
        return res;
    }
}