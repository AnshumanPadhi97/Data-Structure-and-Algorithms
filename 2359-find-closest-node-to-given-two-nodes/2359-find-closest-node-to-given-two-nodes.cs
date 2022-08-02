public class Solution {
    public int ClosestMeetingNode(int[] edges, int node1, int node2) {
        int l = edges.Length;
        
        var a = new int[l];
        Array.Fill(a,int.MaxValue);
        
        var b = new int[l];
        Array.Fill(b,int.MaxValue);
        
        a[node1]=0;
        b[node2]=0;
        
        dfs(edges,node1,a,0,new HashSet<int>());
        dfs(edges,node2,b,0,new HashSet<int>());
        
        int max=int.MaxValue;
        int res=-1;
        for(int i=0;i<l;i++){
            if(Math.Max(a[i],b[i])<max){
                max=Math.Max(a[i],b[i]);
                res=i;
            }
        }
        return res;
    }
    void dfs(int[] edges,int node,int[] dists,int dist,HashSet<int> vis){
        vis.Add(node);
        dists[node]=dist;
        if(edges[node]!=-1 && !vis.Contains(edges[node])){
            dfs(edges,edges[node],dists,dist+1,vis);
        }
    }
}