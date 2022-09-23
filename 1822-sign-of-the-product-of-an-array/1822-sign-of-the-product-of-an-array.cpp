class Solution {
public:
    int arraySign(vector<int>& nums) {
        int n = nums.size();
        int c=0;
        int d=0;
        for(int i=0;i<n;i++){
            if(nums[i]<0){
                c++;
            }
            if(nums[i]==0){
                d=1;
            }
        }
        if(d)return 0;
        if(c%2==0){return 1;}
        return -1;
    }
};