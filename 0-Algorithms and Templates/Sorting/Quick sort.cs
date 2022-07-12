using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6._0_Algorithms_and_Templates.Sorting
{
    internal class Quick_sort
    {
        public void quick_sort(int[] nums)
        {
            h(nums, 0, nums.Length - 1);
        }
        public void h(int[] nums, int i, int j)
        {
            if (i < j)
            {
                var pi = partition(nums, i, j);
                h(nums, i, pi - 1);
                h(nums, pi + 1, j);
            }
        }
        //last element as pivot
        int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);
            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    //swap(arr, i, j);
                }
            }
            //swap(arr, i + 1, high);
            return i + 1;
        }
    }
}
