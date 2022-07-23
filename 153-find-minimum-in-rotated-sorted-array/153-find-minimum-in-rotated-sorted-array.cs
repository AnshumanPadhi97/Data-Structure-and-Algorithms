public class Solution {
    public int FindMin(int[] nums) {
            int lo = 0, hi = nums.Length - 1;
            while (lo < hi)
            {
                var mid = (lo + hi) >> 1;
                if (nums[mid] > nums[hi])
                {
                    lo=mid+1;
                }
                else if(nums[mid]<nums[hi])
                {
                    hi=mid;
                }
            }
            return nums[lo];
    }
}