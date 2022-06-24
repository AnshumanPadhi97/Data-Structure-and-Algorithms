﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6
{
    internal class priority_queue
    {
        public void pq()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };

            var q = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));//max heap
            var q1 = new PriorityQueue<int, int>(); //min heap
            foreach (var item in a)
            {
                q.Enqueue(item, item);
                q1.Enqueue(item, item);
            }
        }
    }
}
