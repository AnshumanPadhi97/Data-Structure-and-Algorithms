public class Solution {
    public int[] SearchRange(int[] nums, int target)
    {
        var res = new int[] { -1, -1 };
        var p1 = pb(nums, target-1);
        var p2 = pb(nums, target);
        if (p1 == p2) return res;
        return new int[] { p1, p2 - 1 };
    }
    int pb(int[] nums, int t)
    {
        int lo = 0, hi = nums.Length;
        while (lo<hi)
        {
            var mid = (hi + lo) >> 1;
            if(nums[mid]> t)
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