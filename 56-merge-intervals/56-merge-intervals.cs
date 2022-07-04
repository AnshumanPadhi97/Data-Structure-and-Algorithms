public class Solution {
    public int[][] Merge(int[][] intervals) {
            var res = new List<int[]>();
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            int l = intervals.Length;
            res.Add(intervals[0]);

            int j = 0;
            for (int i = 1; i < l; i++)
            {
                if (intervals[i][0] <= res[j][1])
                {
                    res[j][1] = Math.Max(intervals[i][1], res[j][1]);
                }
                else
                {
                    res.Add(intervals[i]);
                    j++;
                }
            }

            return res.ToArray();
    }
}