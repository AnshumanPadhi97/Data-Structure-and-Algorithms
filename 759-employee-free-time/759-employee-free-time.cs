/*
// Definition for an Interval.
public class Interval {
    public int start;
    public int end;

    public Interval(){}
    public Interval(int _start, int _end) {
        start = _start;
        end = _end;
    }
}
*/

public class Solution {
    public IList<Interval> EmployeeFreeTime(IList<IList<Interval>> schedule) {
            var pq = new PriorityQueue<Interval, Interval>(Comparer<Interval>.Create((a, b) => a.start - b.start));
            for (int i = 0; i < schedule.Count; i++)
            {
                for (int j = 0; j < schedule[i].Count; j++)
                {
                    pq.Enqueue(schedule[i][j], schedule[i][j]);
                }
            }
            var res = new List<Interval>();
            while (pq.Count > 1)
            {
                var a = pq.Dequeue();
                var b = pq.Dequeue();

                if (b.start > a.end)
                {
                    res.Add(new Interval() { start = a.end, end = b.start });
                }
                if(a.end > b.end)
                {
                    pq.Enqueue(a, a);
                }
                else
                {
                    pq.Enqueue(b, b);
                }
            }
            return res;
    }
}