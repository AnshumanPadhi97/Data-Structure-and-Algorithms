public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int l=s2.Length;
        int p=s1.Length;
        var a = new int[26];
        var b = new int[26];
        for(int i=0;i<p;i++){
            a[s1[i]-'a']++;
        }
        int j=0;
        for(int i=0;i<l;i++){
            b[s2[i]-'a']++;
            if(i-j+1==p){
                if(a.SequenceEqual(b)){
                    return true;
                }
                b[s2[j++]-'a']--;
            }
        }
        return false;
    }
}