class Solution {
public:
    int findUnsortedSubarray(vector<int>& nums) {
        vector<int> a(nums);
        sort(a.begin(),a.end());
        int n = nums.size(), i=0,j=n-1;
        while (i<n && nums[i]==a[i])
        {
            i++;
        }
        while (j>i && nums[j]==a[j])
        {
            j--;
        }
        return j-i+1;
    }
};