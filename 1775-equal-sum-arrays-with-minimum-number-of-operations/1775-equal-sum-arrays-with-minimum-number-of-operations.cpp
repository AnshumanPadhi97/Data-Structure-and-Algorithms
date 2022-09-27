class Solution {
public:
    int minOperations(vector<int>& nums1, vector<int>& nums2) {
        int s1=accumulate(nums1.begin(),nums1.end(),0);
        int s2=accumulate(nums2.begin(),nums2.end(),0);
        if(s1>s2){
            swap(nums1,nums2);
            swap(s1,s2);
        }
        int res=0;
        int diff=s2-s1;
        if(diff==0) return 0;
        
        vector<int> arr;
        for(auto a:nums1){
            arr.push_back(6-a);
        }
        for(auto a:nums2){
            arr.push_back(a-1);
        }
        sort(arr.rbegin(),arr.rend());
        for (int i = 0; i < arr.size(); i++)
        {
            res++;
            diff-=arr[i];
            if(diff<=0) return res;
        }
        return -1;
    }
};