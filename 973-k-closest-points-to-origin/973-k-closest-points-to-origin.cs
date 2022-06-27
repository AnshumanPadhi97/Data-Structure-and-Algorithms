public class Solution {
    public class intmaxCompare : IComparer<double>
    {
        public int Compare(double x, double y) => y.CompareTo(x);
    }
    public int[][] KClosest(int[][] points, int k) {
        
        var ls = new Dictionary<int,double>();
        var pq = new PriorityQueue<(int,double),double>(new intmaxCompare());
        
        for(int i=0;i<points.Length;i++){
            var dist = Math.Sqrt((points[i][0]*points[i][0])+(points[i][1]*points[i][1]));
            
            pq.Enqueue((i,dist),dist);
            
            while(pq.Count>k){
                pq.Dequeue();
            }
        }
        
        List<int[]> res = new List<int[]>();
        while(pq.Count!=0){
            var a = pq.Dequeue();
            res.Add(points[a.Item1]);
        }
        return res.ToArray();
    }
}