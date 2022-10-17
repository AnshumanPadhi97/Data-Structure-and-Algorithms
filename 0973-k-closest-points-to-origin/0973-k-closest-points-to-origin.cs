public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        
        var pq = new PriorityQueue<int,double>(Comparer<double>.Create((a,b)=>b.CompareTo(a)));
        
        for(int i=0;i<points.Length;i++){
            var dist = Math.Sqrt((points[i][0]*points[i][0])+(points[i][1]*points[i][1]));
            
            pq.Enqueue(i,dist);
            
            while(pq.Count>k){
                pq.Dequeue();
            }
        }
        
        var res = new List<int[]>();
        while(pq.Count!=0){
            var a = pq.Dequeue();
            res.Add(points[a]);
        }
        return res.ToArray();
    }
}