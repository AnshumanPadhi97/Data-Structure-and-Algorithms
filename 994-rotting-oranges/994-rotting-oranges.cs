public class Solution {
    public int OrangesRotting(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        int fresh=0;
        int rot=0;
        var q = new Queue<(int,int)>();
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(grid[i][j]==2){
                    q.Enqueue((i,j));
                    rot++;
                }else if(grid[i][j]==1){
                    fresh++;
                }
            }
        }
        if(fresh==0)return 0;
        var res=0;
        int[] dir = new int[]{0,1,0,-1,0};
        while(q.Count>0){
            var l = q.Count;
            res++;
            while(l-->0){
                var a = q.Dequeue();
                var ai = a.Item1;
                var aj = a.Item2;
                for(int i=0;i<4;i++){
                    var nai = ai+dir[i];
                    var naj = aj+dir[i+1];
                    if(nai<0||naj<0||nai>=m||naj>=n||grid[nai][naj]==0||grid[nai][naj]==2){
                        continue;
                    }else{
                        grid[nai][naj]=2;
                        q.Enqueue((nai,naj));
                        fresh--;
                    }
                }
            }
        }
        return fresh==0 ? res-1 : -1;
    }
}