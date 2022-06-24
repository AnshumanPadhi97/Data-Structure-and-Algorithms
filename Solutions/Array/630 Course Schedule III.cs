/*There are n different online courses numbered from 1 to n. You are given an array courses where courses[i] = [durationi, lastDayi] 
 * indicate that the ith course should be taken continuously 
 * for durationi days and must be finished before or on lastDayi.

You will start on the 1st day and you cannot take two or more courses simultaneously.

Return the maximum number of courses that you can take.
 */
public class Solution630
{
    public int ScheduleCourse(int[][] courses)
    {

        Array.Sort(courses, (a, b) => a[1] - b[1]);
        var q = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
        int time = 0;
        foreach (var item in courses)
        {
            if (time + item[0] <= item[1])
            {
                q.Enqueue(item[0], item[0]);
                time += item[0];
            }
            else if (q.Count > 0 && q.Peek() > item[0])
            {
                time += item[0] - q.Dequeue();
                q.Enqueue(item[0], item[0]);
            }
        }
        return q.Count;
    }
}