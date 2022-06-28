public class Solution {
    public int LongestPalindrome(string s) {
        var h = new HashSet<char>();
        int res=0;
        foreach(var item in s){
            if(h.Contains(item)){
                h.Remove(item);
                res+=2;
            }else{
                h.Add(item);
            }
        }
        if(h.Count>0)return res+1;
        return res;
    }
}