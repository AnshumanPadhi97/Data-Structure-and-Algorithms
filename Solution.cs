using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections;

namespace basicDS6
{
    class Solution
    {
        private int MOD = 1000000007;
        //long gcd(long a, long b)
        //{
        //    if (a == 0)
        //        return b;

        //    return gcd(b % a, a);
        //}
        //long res = 0;
        //public long DistinctSequences(int n)
        //{
        //    res = 0;
        //    dp = new int[10000, 10000];
        //    h(0, n, new List<long>());
        //    return res % 1000000007;
        //}
        //int[,] dp = new int[0,0];
        //public void h(int i,int n,List<long> temp)
        //{
        //    if (i > n) return;
        //    if(temp.Count == n)
        //    {
        //        for (int k = 0; k < temp.Count-1; k++)
        //        {
        //            if (gcd(temp[k], temp[k + 1])!=1)
        //            {
        //                return;
        //            }
        //        }
        //        for (int k = 0; k < temp.Count-2; k+=1)
        //        {
        //            if (temp[k] == temp[k + 2] || temp[k] == temp[k+1])
        //            {
        //                return;
        //            }
        //        }
        //        res++;
        //        return;
        //    }
        //    for (int j = 1; j <= 6; j++)
        //    {
        //        temp.Add(j);
        //        h(i + 1, n, temp);
        //        temp.RemoveAt(temp.Count - 1);
        //    }
        //}
        static void Main()
        {
            Solution p = new Solution();
            //Console.WriteLine(p.DistinctSequences(4));
            //Console.WriteLine(p.DistinctSequences(2));
        }
    }
}
