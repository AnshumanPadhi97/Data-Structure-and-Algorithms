public class Solution {
    public int MinRefuelStops(int target, int tank, int[][] stations) {
        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
        var result = 0;
        var prevLocation = 0;
        
        foreach (var station in stations)
        {
            var location = station[0];
            var capacity = station[1];
            tank -= location - prevLocation;
            while (pq.Count > 0 && tank < 0)
            {
                // must refuel in past
                tank += pq.Dequeue();
                result++;
            }
            if (tank < 0)
            {
                return -1;
            }
            pq.Enqueue(capacity, capacity);
            prevLocation = location;
        }
        
        tank -= target - prevLocation;
        while (pq.Count > 0 && tank < 0)
        {
            tank += pq.Dequeue();
            result++;
        }
        if (tank < 0)
        {
            return -1;
        }
        
        return result;
    }
}