public class Solution {
    public int FindPeakElement(int[] nums) {
            int lo = 0, hi = nums.Length - 1;
            while (lo < hi)
            {
                var mid = (lo + hi) >> 1;
                if (nums[mid] > nums[mid+1])
                {
                    hi = mid;
                }
                else
                {
                    lo = mid + 1;
                }
            }
            return lo;
    }
}