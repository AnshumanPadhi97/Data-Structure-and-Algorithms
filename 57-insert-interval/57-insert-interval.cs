public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            var res = new List<int[]>();
            int i = 0, l = intervals.Length;

            while (i < l && intervals[i][1] < newInterval[0])
            {
                res.Add(intervals[i++]);
            }

            while(i<l && intervals[i][0] <= newInterval[1])
            {
                newInterval[0] = Math.Min(intervals[i][0], newInterval[0]);
                newInterval[1] = Math.Max(intervals[i][1], newInterval[1]);
                i++;
            }
        
            res.Add(newInterval);
        
            while (i<l)
            {
                res.Add(intervals[i++]);
            }

            return res.ToArray();
    }
}