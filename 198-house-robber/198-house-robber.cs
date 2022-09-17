public class Solution {
    int[] dp= new int[101];
    public int Rob(int[] nums) {
        Array.Fill(dp,-1);
        return h(nums,0);
    }
    public int h(int[] nums,int i){
        if(i>=nums.Length)return 0;
        if(dp[i]!=-1)return dp[i];
        return dp[i]=Math.Max(h(nums,i+1),nums[i]+h(nums,i+2));
    }
}