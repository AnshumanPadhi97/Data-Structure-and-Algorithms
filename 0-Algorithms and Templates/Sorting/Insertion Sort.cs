using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6._0_Algorithms_and_Templates.Sorting
{
    internal class Insertion_Sort
    {
        public void insertion_sort(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                var key = nums[i];
                var j = i - 1;
                while (j >= 0 && nums[j] > key)
                {
                    nums[j + 1] = nums[j];//duplicate higher numbers
                    j -= 1;
                }
                nums[j + 1] = key;//assign smallest number to small index
            }
        }
    }
}
