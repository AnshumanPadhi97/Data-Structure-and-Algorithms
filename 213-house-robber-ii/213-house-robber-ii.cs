public class Solution {
    public int Rob(int[] nums) {
        int l=nums.Length;
        if(l==0)return 0;
        if(l==1)return nums[0];
        int[] dp1 = new int[l+1];
        int[] dp2 = new int[l+1];
        Array.Fill(dp1,-1);
        Array.Fill(dp2,-1);
        return Math.Max(test(nums,0,nums.Length-1,dp1),test(nums,1,nums.Length,dp2));
    }
    public int test(int[] nums, int i, int j,int[] dp){
        if(i>=j)
            return 0;
        if(dp[i]!=-1)
            return dp[i];
        
        dp[i] = Math.Max(nums[i]+test(nums,i+2,j,dp),test(nums,i+1,j,dp));
        return dp[i];
    }
}