public class Solution {
    public int HammingWeight(uint n) {
        int c=0;
        for(int i=0;i<32;i++){
            if(((n>>i)&1)==1){
                c++;
            }
        }
        return c;
    }
}