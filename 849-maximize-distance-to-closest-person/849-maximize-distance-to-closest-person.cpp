class Solution {
public:
    int maxDistToClosest(vector<int>& seats) {
        int l = seats.size();
        
        vector<int> left(l,-1);
        vector<int> right(l,-1);
        
        int i=0;
        int lastOne = -1;
        int maxDis = -1;
        
        while (i<l)
        {
            if(seats[i]==1){
                lastOne = i;
            }else{
                left[i] = lastOne;
            }
            i++;
        }
        
        i=l-1;
        lastOne=-1;
        
        while (i>=0)
        {
            if(seats[i]==1){
                lastOne=i;
            }else{
                right[i]=lastOne;
            }
            i--;
        }
        
        for (int i = 0; i < l; i++)
        {
            if(seats[i]==0){
                int l = left[i] != -1 ? i-left[i] : INT_MAX;
                int r = right[i] != -1 ? right[i]-i : INT_MAX;
                int a = min(l,r);
                maxDis = max(maxDis,a);
            }
        }
        
        return maxDis;
    }
};