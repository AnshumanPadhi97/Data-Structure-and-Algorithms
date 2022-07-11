public class Solution {
    public int CharacterReplacement(string s, int k) {
        int res=0,i=0,j=0,l=s.Length,curr=0;
        var a = new int[26];
        while(j<l){
            curr = Math.Max(curr,++a[s[j++]-'A']);
            while(j-i-curr>k){
                a[s[i++]-'A']--;
            }
            res=Math.Max(res,j-i);
        }
        return res;
    }
}