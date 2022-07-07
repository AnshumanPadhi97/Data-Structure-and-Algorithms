public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
            IList<IList<int>> res = new List<IList<int>>();
            Array.Sort(nums);
            int l = nums.Length;
            for (int k = 0; k < l-1; k++)
            {
                if ((k == 0) || (k > 0 && nums[k - 1] != nums[k]))
                {
                    var x = nums[k];
                    var lo = k + 1;
                    var hi = l - 1;
                    while (lo < hi)
                    {
                        if (nums[lo] + nums[hi] == -x)
                        {
                            res.Add(new List<int>() { nums[lo], nums[hi], nums[k] });
                            while (lo < hi && nums[lo] == nums[lo + 1]) lo++;
                            while (lo < hi && nums[hi] == nums[hi - 1]) hi--;
                            lo++;
                            hi--;
                        }
                        else if(nums[lo] + nums[hi] < -x)
                        {
                            lo++;
                        }
                        else
                        {
                            hi--;
                        }
                    }
                }
            }
            return res;
    }
}