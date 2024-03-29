class Solution {
public:
    int numFactoredBinaryTrees(vector<int>& arr) {
        sort(arr.begin(),arr.end());
        long res=0,mod=1e9+7;
        unordered_map<int, long> dp;
        for(int i=0;i<arr.size();i++){
            dp[arr[i]]=1;
            for(int j=0;j<i;j++){
                if(arr[i]%arr[j]==0){
                    dp[arr[i]]=(dp[arr[i]]+dp[arr[j]]*dp[arr[i]/arr[j]])%mod;
                }
            }
            res=(res+dp[arr[i]])%mod;
        }
        return res;
    }
};