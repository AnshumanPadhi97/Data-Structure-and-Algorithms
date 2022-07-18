public class Solution {
    public int BitwiseComplement(int n) {
        int a = 0;
        if(n==0)return 1;
        int num = n;
        while(n>0){
            a++;
            n>>=1;
        }
        var b  = (int)Math.Pow(2,a)-1;
        return num^b;
    }
}