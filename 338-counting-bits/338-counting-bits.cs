public class Solution {
    public int[] CountBits(int n) {
        var ls = new List<int>();
        for(int i=0;i<=n;i++){
            ls.Add(count(i));
        }
        return ls.ToArray();
    }
    public int count(int n){
        int c=0;
        for(int i=0;i<32;i++){
            if(((n>>i)&1)==1)
                c++;
        }
        return c;
    }//O((n+1)*32)
}