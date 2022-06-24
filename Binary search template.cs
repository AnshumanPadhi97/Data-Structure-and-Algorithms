using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6
{
    public class Binary_search_template
    {
        public bool Condition(int a,int b)
        {
            return false;
        }
        public int Basic_BinarySearch(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            int lo = 0, hi = nums.Length;
            while (lo < hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (Condition(nums[mid],target))
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
}
