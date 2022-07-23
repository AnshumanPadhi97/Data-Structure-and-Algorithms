public class Solution {
    public int MySqrt(int x) {
        int lo=1,hi=x;
        if(x==0)return 0;
        while(lo<hi)
        {
            int mid = lo + (hi-lo)/2;
            if(mid > x/mid)
            {
                hi=mid-1;
            }
            else
            {
                if(mid+1>x/(mid+1))
                    return mid;
                lo=mid+1;
            }
        }
        return lo;   
    }
}