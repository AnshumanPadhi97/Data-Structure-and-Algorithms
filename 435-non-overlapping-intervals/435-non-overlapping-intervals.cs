public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
            Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));
            var res = 0;
            int l = intervals.Length;
            var prev = intervals[0];
            for (int i = 1; i < l; i++)
            {
                if (prev[1] > intervals[i][0])
                {
                    res++;
                }
                else
                {
                    prev = intervals[i];
                }
            }
            return res;
    }
}