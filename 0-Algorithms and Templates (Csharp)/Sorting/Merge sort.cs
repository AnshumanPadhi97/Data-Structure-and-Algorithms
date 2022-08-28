using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6._0_Algorithms_and_Templates.Sorting
{
    internal class Merge_sort
    {
        public void merge_sort(int[] nums)
        {
            h(nums, 0, nums.Length - 1);
        }
        public void h(int[] nums, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) >> 1;
                h(nums, l, m);
                h(nums, m + 1, r);//divide array until 1 element
                merge(nums, l, m, r);//merge sorted arrays
            }
        }
        public void merge(int[] nums, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];
            int i = 0, j = 0;

            for (i = 0; i < n1; i++)
            {
                L[i] = nums[l + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = nums[m + 1 + j];
            }

            i = 0;
            j = 0;
            int k = l;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    nums[k] = L[i++];
                }
                else
                {
                    nums[k] = R[j++];
                }
                k++;
            }
            while (i < n1)
            {
                nums[k++] = L[i++];
            }
            while (j < n2)
            {
                nums[k++] = R[j++];
            }
        }
    }
}
