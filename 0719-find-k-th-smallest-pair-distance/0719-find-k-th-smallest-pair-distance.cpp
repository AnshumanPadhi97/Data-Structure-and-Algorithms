class Solution {
public:
    bool check(vector<int>& nums,int mid,int k){
        int c=0;
        int i=0,j=0;
        int l = nums.size();
        while (i<l || j<l)
        {
            while (j<l && nums[j] - nums[i] <= mid)
            {
                j++;
            }
            c+=j-i-1;//no of pairs which has absolute diff
            i++;
        }
        return c>=k;//if pairs >= k decrease search space from right
    }
    
    int smallestDistancePair(vector<int>& nums, int k) 
    {
        int l = 0, h = *max_element(nums.begin(),nums.end()) - *min_element(nums.begin(),nums.end());
        //range 0 - (max-min)
        
        sort(nums.begin(),nums.end());
        
        while (l<h)
        {
            int mid = l + (h-l)/2;
            if(check(nums,mid,k)){
                h=mid;
            }else{
                l=mid+1;
            }
        }
        
        return l;
    }
};