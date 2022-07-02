using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections;

namespace basicDS6
{
    class st
    {
        private int MOD = 1000000007;
        public class comp : IComparer<int>
        {
            public int Compare(int x,int y)
            {
                return y - x;//descending
                return x - y;//ascending
            }
        }
        static void Main()
        {
            st p = new st();

            var pq = new PriorityQueue<int, int>(new comp());


            //int T = int.Parse(Console.ReadLine());
            //for (int test_no = 1; test_no < T + 1; test_no++)
            //{
            //    Console.Write(String.Format("Case #{0}: ", test_no));
            //    p.Test();
            //}
        }
        public void Test()
        {
            IEnumerable<int> nM = Console.ReadLine().Split().Select(x => int.Parse(x));
            int l = nM.ElementAt(0);
            int r = nM.ElementAt(1);
            Console.WriteLine((l + r) / 2);
        }
    }
}
