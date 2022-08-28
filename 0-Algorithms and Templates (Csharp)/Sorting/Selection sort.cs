using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6._0_Algorithms_and_Templates.Sorting
{
    internal class Selection_sort
    {
        //o(n2)
        public void select_sort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                var ind = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[ind])
                    {
                        ind = j;
                    }
                }
                var temp = nums[ind];
                nums[ind] = nums[i];
                nums[i] = temp;
            }
        }
    }
}
