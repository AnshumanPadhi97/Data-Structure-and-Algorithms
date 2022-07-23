public class Solution {
    public int MaxVowels(string s, int k) {
        
        var vowels = new int[]{1,0,0,0,1,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0};  
        
        int res = 0, curr = 0;
        
        for (int i = 0; i < s.Length; ++i) {
            curr += vowels[s[i]-'a'];
            
            if (i >= k) {
                curr -= vowels[s[i - k] - 'a'];
            }
                
            res = Math.Max(curr, res);
        }
        
        return res;
    }
}