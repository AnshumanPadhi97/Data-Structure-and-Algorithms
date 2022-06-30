public class Solution {
    public int MinMoves2(int[] nums) {
            int res = 0;
            Array.Sort(nums);
            int l = nums.Length;
            int target = nums[l / 2];
            foreach (var item in nums)
            {
                res += Math.Abs(target - item);
            }
            return res;
    }
}