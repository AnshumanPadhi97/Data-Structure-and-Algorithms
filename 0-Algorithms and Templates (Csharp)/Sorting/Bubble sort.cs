using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6._0_Algorithms_and_Templates.Sorting
{
    internal class Bubble_sort
    {
        //o(n2)
        public void bubble_sort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - i - 1; j++)//get in order from back, so skip any modifications from back
                {
                    if (nums[j] > nums[j + 1])
                    {
                        var temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }
    }
}
