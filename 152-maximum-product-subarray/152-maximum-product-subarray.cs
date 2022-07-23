public class Solution {
    public int MaxProduct(int[] nums) {
            var res = nums[0];
            var max = res;
            var min = res;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    var temp = max;
                    max = min;
                    min = temp;
                }
                max=Math.Max(nums[i], nums[i]*max);
                min=Math.Min(nums[i], nums[i]*min);
                res = Math.Max(max, res);
            }
            return res;
    }
}