public class Solution {
    public bool BackspaceCompare(string s, string t) {
        return h(s).Equals(h(t));
    }
    public string h(string s){
        int j=s.Length-1;
        int c=0;
        string res="";
        while(j>=0){
            if(s[j]=='#'){
                c++;
                j--;
            }else{
                if(c>0){
                    c--;
                    j--;
                }else{
                    res+=s[j];
                    j--;
                }
            }
        }
        return res;
    }
}