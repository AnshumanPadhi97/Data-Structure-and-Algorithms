public class Solution {
    public long TaskSchedulerII(int[] tasks, int space) {
        long day = 0;
        Dictionary<int, long> lastindex = new Dictionary<int, long>();
        for (int i = 0; i < tasks.Length; i++)
        {
            day++;
            if (lastindex.ContainsKey(tasks[i]))
            {
                day = Math.Max(lastindex[tasks[i]] + space + 1, day);
                lastindex[tasks[i]] = day;
            }
            else
            {
                lastindex.Add(tasks[i], day);
            }
        }
        return day;
    }
}