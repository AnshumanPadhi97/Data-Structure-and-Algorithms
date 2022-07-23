public class Solution {
    public int Search(int[] nums, int target) {
            int lo = 0, hi = nums.Length-1;
            while (lo<hi)
            {
                var mid = (hi + lo) >> 1;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[lo] <= nums[mid])
                {
                    if (target >= nums[lo] && target <= nums[mid])
                    {
                        hi = mid - 1;
                    }
                    else
                    {
                        lo = mid + 1;
                    }
                }
                else
                {
                    if (target > nums[mid] && target <= nums[hi])
                    {
                        lo = mid + 1;
                    }
                    else
                    {
                        hi = mid - 1;
                    }
                }
            }
            return nums[lo] == target ? lo : -1;
    }
}