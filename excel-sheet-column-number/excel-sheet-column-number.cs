public class Solution {
    public int TitleToNumber(string a) {
        int res=0;
        foreach(var item in a){
            res=res*26+item-'A'+1;
        }
        return res;
    }
}