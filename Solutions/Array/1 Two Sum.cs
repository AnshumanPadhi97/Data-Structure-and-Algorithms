//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

public class Solution2
{
    public int[] TwoSum(int[] nums, int target)
    {
        int l = nums.Length;
        int[] res = new int[2];
        var h = new HashSet<int>();
        for (int i = 0; i < l; i++)
        {
            if (h.Contains(target - nums[i]))
            {
                res[0] = i;
                res[1] = Array.IndexOf(nums, target - nums[i]);
            }
            else
            {
                h.Add(nums[i]);
            }
        }
        return res;
    }
}