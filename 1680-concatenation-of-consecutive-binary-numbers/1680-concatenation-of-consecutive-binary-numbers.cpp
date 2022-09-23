class Solution {
public:
    int concatenatedBinary(int n) {
        long res=0, mod = 1e9+7;
        int l=0;
        for (int i = 1; i <= n; i++)
        {
            //if current index is power of 2 then increase len by 1
            //create space for concat and set
            
            if((i&(i-1))==0){
                l+=1;   
            }
            
            res = ((res<<l) | i) % mod;
        }
        return res;
    }
};