class Solution {
public:
    int h(vector<int>& nums,int mid,int m){
        int curr=0;
        int c=1;
        for (auto &&i : nums)
        {
            curr+=i;
            if(curr>mid){
                c++;
                curr=i;
                if(c>m)return false;
            }
        }
        return true;
    }
    int splitArray(vector<int>& nums, int m) {
        int low = *max_element(nums.begin(),nums.end());
        int high = accumulate(nums.begin(),nums.end(),0);
        while (low<high)
        {
            int mid = low+(high-low)/2;
            if(h(nums,mid,m)){
                high=mid;
            }else{
                low=mid+1;
            }
        }        
        return low;
    }
};