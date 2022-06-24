using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6.Algorithms
{
    internal class monotonos_stack
    {
        //monotonous increase stack
        int[] previous_less(int[] t)
        {
            int[] prev_less = new int[t.Length];

            var st = new Stack<int>(); //store indexes

            for (int i = 0; i < t.Length; i++)
            {
                while (st.Count > 0 && t[st.Peek()] > t[i])
                {
                    st.Pop();
                }
                prev_less[i] = st.Count == 0 ? -1 : st.Peek();
                st.Push(i);
            }

            return prev_less;
        }

        //monotonous decrease stack
        int[] next_less(int[] t)
        {
            int[] next_less = new int[t.Length];

            var st = new Stack<int>(); //store indexes

            for (int i = 0; i < t.Length; i++)
            {
                while (st.Count > 0 && t[st.Peek()] > t[i])
                {
                    var x = st.Pop();
                    next_less[x] = i;
                }
                st.Push(i);
            }

            return next_less;
        }
    }
}
