public class Solution {
    public int MaxResult(int[] nums, int k) {
        int l = nums.Length;
        long[] dp = new long[l];
		
        for (int i = 0; i < l; i++) 
            dp[i] = long.MinValue;

        dp[0] = nums[0];
        k++;
        List<int> slideWin = new List<int>();
        slideWin.Add(0);

        for (int i = 1; i < l; i++)
        {
            if (i >= k && slideWin[0] == i - k)
                slideWin.RemoveAt(0);

            dp[i] = nums[i] + dp[slideWin[0]];
            
            while (slideWin.Count > 0 && dp[slideWin[slideWin.Count - 1]] <= dp[i])
                slideWin.RemoveAt(slideWin.Count - 1);

            slideWin.Add(i);
        }
        return (int)dp[l - 1];
    }
}