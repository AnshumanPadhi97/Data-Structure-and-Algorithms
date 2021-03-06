public class Solution {
    public int[] SmallestTrimmedNumbers(string[] nums, int[][] queries) {
            int[] res = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                int[] q = queries[i];
                var pq = new PriorityQueue<int, (string, int)>();
                for (int j = 0; j < nums.Length; j++)
                {
                    int start = nums[j].Length - q[1];
                    string c = nums[j].Substring(start);
                    pq.Enqueue(j, (c, j));
                }
                int cnt = q[0];
                for (int k = 1; k < cnt; k++)
                {
                    pq.Dequeue();
                }
                res[i] = pq.Peek();
            }

            return res;
    }
}