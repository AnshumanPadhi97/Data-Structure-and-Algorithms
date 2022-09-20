class Solution {
public:
    int minEatingSpeed(vector<int>& piles, int h) {
        int low=1,high=*max_element(piles.begin(),piles.end());
        while (low<high)
        {
            int middle = low+(high-low)/2;
            int curr=0;
            for (int i = 0; i < piles.size(); i++)
            {
                curr+=piles[i]/middle+(piles[i]%middle!=0);
            }
            if(curr<=h){
                high=middle;
            }else{
                low=middle+1;
            }
        }
        return low;
    }
};