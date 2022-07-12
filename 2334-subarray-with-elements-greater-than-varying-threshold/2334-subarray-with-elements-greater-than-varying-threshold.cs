public class Solution {
    public int ValidSubarraySize(int[] nums, int threshold) {
            var st = new Stack<int>();
            for (int i = 0; i <= nums.Length; i++)
            {
                var next = i==nums.Length ? 0 : nums[i];
                while (st.Count>0 && next < nums[st.Peek()])
                {
                    var a = nums[st.Pop()];
                    var j = st.Count == 0 ? -1 : st.Peek();
                    if (a > threshold / (i - j - 1))
                    {
                        return i - j - 1;
                    }
                }
                st.Push(i);
            }
            return -1;
    }
}