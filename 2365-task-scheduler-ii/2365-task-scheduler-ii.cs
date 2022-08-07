public class Solution {
    public long TaskSchedulerII(int[] tasks, int space) {
        long day = 0;
        var d = new Dictionary<int, long>();
        for (int i = 0; i < tasks.Length; i++)
        {
            day++;
            if (d.ContainsKey(tasks[i]))
            {
                day = Math.Max(d[tasks[i]] + space + 1, day);
                d[tasks[i]] = day;
            }
            else
            {
                d.Add(tasks[i], day);
            }
        }
        return day;
    }
}