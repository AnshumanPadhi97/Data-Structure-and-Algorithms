public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        int[] dp = new int[n];
        Array.Fill(dp,-1);
        return check(nums,0,dp,n);
    }
    public int check(int[] nums, int i, int[] dp, int l){
        if(i>=l)return 0;
        if(dp[i]!=-1)return dp[i];
        return dp[i] = Math.Max(nums[i]+check(nums,i+2,dp,l),check(nums,i+1,dp,l));
    }
}