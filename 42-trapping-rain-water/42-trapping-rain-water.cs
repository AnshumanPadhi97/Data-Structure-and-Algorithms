public class Solution {
    public int Trap(int[] height) {
            var st = new Stack<int>();
            int l = height.Length;
            var res = 0;
            for (int i = 0; i < height.Length; i++)
            {
                while (st.Count > 0 && height[st.Peek()] < height[i])
                {
                    var bottom = height[st.Pop()];
                    if (st.Count == 0) break;

                    var left = st.Peek();
                    var w = (i - left - 1) * (Math.Min(height[i], height[left]) - bottom);
                    res += w;
                }
                st.Push(i);
            }
            return res;
    }
}