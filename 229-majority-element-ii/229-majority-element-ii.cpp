class Solution {
public:
    vector<int> majorityElement(vector<int>& nums) {
        int n = nums.size();
        int need = n/3;
        map<int,int> m;
        for(int i=0;i<n;i++){
            m[nums[i]]++;
        }
        vector<int> res;
        for(auto i:m){
            if(i.second>need){
                res.push_back(i.first);
            }
        }
        return res;
    }
};