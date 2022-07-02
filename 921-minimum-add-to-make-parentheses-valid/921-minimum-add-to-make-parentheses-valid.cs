public class Solution {
    public int MinAddToMakeValid(string s) {
        int bal=0;
        int ans=0;
        foreach(var item in s){
            if(item=='('){
                bal+=1;
            }else{
                bal-=1;
            }
            if(bal==-1){
                ans++;
                bal++;
            }
        }
        return ans+bal;
    }
}