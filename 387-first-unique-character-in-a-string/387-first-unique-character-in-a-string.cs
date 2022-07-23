public class Solution {
    public int FirstUniqChar(string s) {
        var d = new Dictionary<char,int>();
        foreach(var item in s){
            if(!d.ContainsKey(item)){
                d.Add(item,1);
            }else{
                d[item]++;
            }
        }
        int i=0;
        for(i=0;i<s.Length;i++){
            if(d[s[i]]==1){
                return i;
            }
        }
        return -1;
    }
}