public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            // Use a min heap to track the minimum end time of merged intervals
            var pq = new PriorityQueue<int[], int[]>(Comparer<int[]>.Create((a, b) => a[1] - b[1]));
            
            // start with the first meeting, put it to a meeting room
            pq.Enqueue(intervals[0], intervals[0]);

            for (int i = 1; i < intervals.Length; i++)
            {
                // get the meeting room that finishes earliest
                var a = pq.Dequeue();
                if (intervals[i][0] >= a[1])
                {
                    // if the current meeting starts right after 
                    // there's no need for a new room, merge the interval
                    a[1] = intervals[i][1];
                }
                else
                {
                    // otherwise, this meeting needs a new room
                    pq.Enqueue(intervals[i], intervals[i]);
                }
                //put again
                pq.Enqueue(a,a);
            }

            return pq.Count;
    }
}