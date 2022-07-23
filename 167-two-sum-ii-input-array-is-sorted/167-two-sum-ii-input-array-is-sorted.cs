public class Solution {
    public int[] TwoSum(int[] nums, int target) {
            var res = new int[2];
            int lo = 0, hi = nums.Length - 1;
            while (lo < hi)
            {
                if (nums[lo] + nums[hi] == target)
                {
                    res[0] = lo+1;
                    res[1] = hi+1;
                    break;
                }
                else if(nums[lo] + nums[hi] > target)
                {
                    hi--;
                }
                else
                {
                    lo++;
                }
            }
            return res;
    }
}