public class Solution {
    
        public IList<int> GoodIndices(int[] arr, int k)
        {
            int l = arr.Length;

            int[] prefix = new int[l];
            int[] suffix = new int[l];
            List<int> ans = new List<int>();

            for (int i = 1; i < l; i++)
            {
                if (arr[i] <= arr[i - 1])
                {
                    prefix[i] = prefix[i - 1] + 1;
                }
            }

            for (int i = l - 2; i >= 0; i--)
            {
                if (arr[i] <= arr[i + 1])
                {
                    suffix[i] = suffix[i + 1] + 1;
                }
            }

            for (int i = k; i < l-k; i++)
            {
                if (prefix[i-1] >= k-1 && suffix[i+1] >= k-1)
                {
                    ans.Add(i);
                }
            }

            return ans;
        }
}