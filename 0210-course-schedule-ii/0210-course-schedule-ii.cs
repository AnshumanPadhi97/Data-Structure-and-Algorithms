public class Solution {
    public int[] FindOrder(int n, int[][] p) {
        var q = new Queue<int>();
        var h = new HashSet<int>();
        var g = new List<List<int>>();
        var ind = new int[n];
        for(int i=0;i<n;i++){
            g.Add(new List<int>());
        }
        foreach(var item in p){
            ind[item[0]]++;
            g[item[1]].Add(item[0]);
        }
        for(int i=0;i<n;i++){
            if(ind[i]==0){
                q.Enqueue(i);
            }
        }
        var res = new List<int>();
        while(q.Count>0){
            var a = q.Dequeue();
            if(h.Contains(a)){
                return new int[0];
            }
            h.Add(a);
            res.Add(a);
            foreach(var item in g[a]){
                if(--ind[item]==0){
                    q.Enqueue(item);
                }
            }
        }
        return h.Count == n ? res.ToArray() : new int[0];
    }
}