public class Solution {
    public bool IsBipartite(int[][] g) {
        
        //0-no color, 1 red, -1 blue
        
        var n = g.Length;
        var color = new int[n];
        var q = new Queue<int>();
        
        for(int i=0;i<n;i++)
        {
            if(color[i]!=0)//colored
            {   
                continue;
            }
            
            color[i]=1;
            q.Enqueue(i);
            
            while(q.Count>0)
            {
                var a = q.Dequeue();
                foreach(var item in g[a])
                {
					// Color neighbor with opposite color
                    if(color[item]==0){
                        color[item]=-color[a];
                        q.Enqueue(item);
                    }
                    
					// If the neighbor has the same color - can't bipartite.
                    else if(color[item]==color[a])
                    {
                        return false;
                    }
                }
            }
        }
        return true;
    }
}