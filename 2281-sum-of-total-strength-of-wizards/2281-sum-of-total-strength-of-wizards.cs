public class Solution {
        public int TotalStrength(int[] strength)
        {
            int n = strength.Length;
            int mod = (int)Math.Pow(10, 9) + 7;
            
            var left = new int[n];
            Array.Fill(left, -1);

            var st = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                while (st.Count>0 && strength[st.Peek()] >= strength[i])
                {
                    st.Pop();
                }
                left[i] = st.Count == 0 ? -1 : st.Peek();
                st.Push(i);
            }

            st.Clear();
            var right = new int[n];
            Array.Fill(right, n);
            for (int i = n-1; i >= 0; i--)
            {
                while (st.Count>0 && strength[st.Peek()] > strength[i])
                {
                    st.Pop();
                }
                right[i] = st.Count == 0 ? n : st.Peek();
                st.Push(i);
            }

            long[] p = new long[n+1];
            for (int i = 0; i < n; i++)
            {
                p[i + 1] = (p[i] + strength[i]) % mod;
            }
            long[] pp = new long[n + 2];//prefix sum of prefix sum
            for (int i = 0; i <= n; i++)
            {
                pp[i + 1] = (pp[i] + p[i]) % mod;
            }

            long res = 0;
            for (int i = 0; i < n; i++)
            {
                res += ((pp[right[i] + 1] - pp[i + 1]) * (i - left[i]) % mod + mod * 2 - (pp[i + 1] - pp[left[i] + 1]) * (right[i] - i) % mod) % mod * strength[i] % mod;
                res %= mod;
            }
            return (int)res;
        }
}