public class Solution {
    int[]dp =new int[1001];
    public int CombinationSum4(int[] nums, int t) {
        int l = nums.Length;
        Array.Sort(nums);
        Array.Fill(dp,-1);
        return h(nums,t);
    }
    public int h(int[] nums, int t){
        if(t==0)return 1;
        if(dp[t]!=-1)return dp[t];
        int res=0;
        foreach(var item in nums){
            if(item<=t){
                res+=h(nums,t-item);
            }
        }
        return dp[t]=res;
    }
}