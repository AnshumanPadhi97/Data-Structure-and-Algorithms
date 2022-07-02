using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6.Algorithms
{
    internal class priority_queue
    {
        public class comp : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                return y - x;//descending
                return x - y;//ascending
            }
        }
        public void pq()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };

            var q = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));//max heap
            var q1 = new PriorityQueue<int, int>(); //min heap
            var q2 = new PriorityQueue<int, int>(new comp()); //custom comparer
        }
    }
}
