public class Solution {
    public long CountExcellentPairs(int[] nums, int k) {
        var count = new long[30];
        foreach (int num in nums.Distinct())
        {
            int onesCount = Convert.ToString(num, 2).Count(a => a == '1');
            count[onesCount]++;
        }

        long result = 0;
        for (int i = 1; i < 30; ++i)
            for (int j = 1; j < 30; ++j)
                if (i + j >= k)
                    result += count[i] * count[j];
        return result;
    }
}