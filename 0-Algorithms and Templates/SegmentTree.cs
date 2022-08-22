using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6._0_Algorithms_and_Templates
{
    public class SegementTree
    {
        public int[] seg;
        public SegementTree(int n)
        {
            seg = new int[4 * n];
        }

        public void build(int ind, int low, int high, int[] arr)
        {
            if (low == high)
            {
                seg[ind] = arr[low];
                return;
            }

            var mid = (low + high) >> 1;
            build(2 * ind + 1, low, mid, arr);
            build(2 * ind + 2, mid + 1, high, arr);

            seg[ind] = Math.Min(seg[2 * ind + 1], seg[2 * ind + 2]);//for range min query //can be used for others also
        }

        public int query(int ind, int low, int high, int l, int r)
        {
            //no overlap
            //l r low high, low high l r
            if (r < low || high < l)
            {
                return int.MaxValue;
            }

            //complete overlap
            //low l r high
            if (l >= low && r <= high)
            {
                return seg[ind];
            }

            //partial overlap so go left and right both
            var mid = (low + high) >> 1;
            int left = query(2 * ind + 1, low, mid, l, r);
            int right = query(2 * ind + 1, mid + 1, high, l, r);

            return Math.Min(left, right);//for range min query //can be used for others also
        }

        public void update(int ind, int low, int high, int i, int val)
        {
            if (low == high)
            {
                seg[low] = val;//update val
                return;
            }

            var mid = (low + high) >> 1;
            if (i <= mid) update(2 * ind + 1, low, mid, i, val);//go left
            else update(2 * ind + 2, mid + 1, high, i, val);//go right

            seg[ind] = Math.Min(seg[2 * ind + 1], seg[2 * ind + 2]);//for range min query //can be used for others also
        }
    }
}
