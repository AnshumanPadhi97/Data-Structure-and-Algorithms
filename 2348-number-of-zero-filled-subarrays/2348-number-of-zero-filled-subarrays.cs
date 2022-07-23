public class Solution {
    public long ZeroFilledSubarray(int[] nums) {
        long a = 0, b = 0;
        foreach (var item in nums)
        {
            if (item != 0) a = 0;
            else
            {
                a++;
            }
            b += a;
        }
        return b;
    }
}