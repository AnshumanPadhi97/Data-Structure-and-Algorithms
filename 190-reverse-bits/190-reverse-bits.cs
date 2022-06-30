public class Solution {
    public uint reverseBits(uint n) {
        uint res=0;
        int i=0;
        while(i<32){
            res=res<<1;
            res|=(n&1);
            n>>=1;
            i++;
        }
        return res;
    }
}