public class Solution {
        public int[] SearchRange(int[] nums, int target)
        {
            var res = new int[] { -1, -1 };
            res[0] = find1(nums, target);
            res[1] = find2(nums, target);
            return res;
        }
        int find1(int[] nums,int target)
        {
            var res = -1;
            int lo = 0, hi = nums.Length - 1;
            while (lo<=hi)
            {
                var mid = (lo + hi) >> 1;
                if(nums[mid] >= target)
                {
                    hi = mid - 1;
                }
                else
                {
                    lo = mid + 1;
                }
                if (nums[mid]==target)
                {
                    res = mid;
                }
            }
            return res;
        }
        int find2(int[] nums, int target)
        {
            var res = -1;
            int lo = 0, hi = nums.Length - 1;
            while (lo <= hi)
            {
                var mid = (lo + hi) >> 1;
                if (nums[mid] <= target)
                {
                    lo = mid + 1;
                }
                else
                {
                    hi = mid - 1;
                }
                if (nums[mid]==target)
                {
                    res = mid;
                }
            }
            return res;
        }
}