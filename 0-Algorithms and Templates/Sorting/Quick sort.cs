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
            quickSort(nums, 0, nums.Length - 1);
        }
        public void quickSort(int[] nums, int l, int h)
        {
            if (l < h)
            {
                var j = partition(nums, l, h);
                quickSort(nums, l, j);
                quickSort(nums, j + 1, j);
            }
        }

        int partition(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int i = low, j = high;
            while (i < j)
            {
                do
                {
                    i++;
                } while (arr[i]<=pivot);
                
                do
                {
                    j--;
                } while (arr[j]>pivot);

                if (i < j)
                {
                    swap(arr[i], arr[j]);
                }
            }
            swap(arr[low], arr[j]);
            return j;
        }

        public void swap(int a,int b)
        {
            var c = b;
            b = a;
            a = c;
        }
    }
}
