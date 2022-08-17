public class Solution {
    public int LengthOfLIS(int[] nums) {
        int l=nums.Length;
        int[] dp = new int[l];
        Array.Fill(dp,1);
        for(int i=1;i<l;i++){
            for(int j=0;j<i;j++){
                if(nums[j]<nums[i])
                    dp[i]=Math.Max(dp[i],dp[j]+1);
            }
        }
        return dp.Max();
    }
}