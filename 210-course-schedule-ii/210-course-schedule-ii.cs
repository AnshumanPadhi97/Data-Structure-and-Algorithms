public class Solution {
    public int[] FindOrder(int n, int[][] p) {
        var g = new List<List<int>>();
        var ind = new int[n];
        var res = new List<int>();
        var q = new Queue<int>();
        var h = new HashSet<int>();
        for(int i=0;i<n;i++){
            g.Add(new List<int>());
        }
        foreach(var item in p){
            g[item[1]].Add(item[0]);
            ind[item[0]]++;
        }
        for(int i=0;i<n;i++){
            if(ind[i]==0)
                q.Enqueue(i);
        }
        while(q.Count>0){
            var u = q.Dequeue();
            if(h.Contains(u)){
                return new int[0];
            }else{
                h.Add(u);
                res.Add(u);
            }
            foreach(var item in g[u]){
                ind[item]-=1;
                if(ind[item]==0){
                    q.Enqueue(item);
                }
            }
        }
        if(h.Count!=n)return new int[0];
        return res.ToArray();
    }
}