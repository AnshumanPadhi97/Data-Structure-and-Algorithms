class Solution {
public:
    bool isPossible(vector<int>& nums) {
        int n=nums.size();
        unordered_map<int,int> m;
        for(auto i:nums){
            m[i]++;
        }
        vector<vector<int>> seq;
        for(int i=0;i<n;){
            int curr=nums[i];
            int c = m[curr];
            int sc = seq.size();
            for(int j=0;j<c;j++){
                if(sc>0 && seq[sc-1].back()+1 == curr){
                    seq[sc-1].push_back(curr);
                    sc--;
                }else{
                    seq.push_back({curr});
                }
            }
            i+=c;
        }
        for(auto i:seq){
            if(i.size()<3)return false;
        }
        return true;
    }
};