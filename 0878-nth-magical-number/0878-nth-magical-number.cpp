class Solution {
public:
    int nthMagicalNumber(int n, int a, int b) {
        int mod = 1e9+7;
        
        int l = a/__gcd(a,b) * b;
        long lo = 0;
        long hi = (long) n*min(a,b);
        
        while (lo<hi)
        {
            long mid = lo + (hi-lo)/2;
            
            if(mid/a + mid/b - mid/l < n)
            {
                lo=mid+1;
            }
            else
            {
                hi=mid;
            }
        }
        return (int)(lo%mod);
    }
};