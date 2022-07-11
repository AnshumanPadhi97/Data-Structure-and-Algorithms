public class Solution {
    public int LengthOfLongestSubstringKDistinct(string s, int k) {
        int i=0,j=0,l=s.Length;
        int res=0;
        var d = new Dictionary<char,int>();
        while(j<l){
            if(d.ContainsKey(s[j])){
                d[s[j]]++;
            }else{
                d.Add(s[j],1);
            }
            j++;
            while(i<l && d.Count>k){
                d[s[i]]-=1;
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