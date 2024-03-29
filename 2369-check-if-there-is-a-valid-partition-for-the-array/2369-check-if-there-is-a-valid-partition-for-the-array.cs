public class Solution {
    public bool ValidPartition(int[] nums) {
        
        int n = nums.Length;
        
        bool[] dp = new bool[n + 1];
        dp[0] = true;
        
        for (int i = 0; i < n - 1; i++)
        {
            if (dp[i])
            {
                if (i + 1 < n && nums[i] == nums[i + 1])
                    dp[i + 1 + 1] = true;
                if (i + 2 < n && nums[i] == nums[i + 1] && nums[i] == nums[i + 2])
                    dp[i + 2 + 1] = true;
                else if (i + 2 < n && nums[i] == nums[i + 1] - 1 && nums[i] == nums[i + 2] - 2)
                    dp[i + 2 + 1] = true;
            }
        }
        return dp.Last();
    }
}