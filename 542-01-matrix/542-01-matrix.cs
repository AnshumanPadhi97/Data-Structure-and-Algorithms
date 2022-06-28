public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        var m = mat.Length;
        var n = mat[0].Length;
        var q = new Queue<(int,int)>();
        var res= new int[m][];
        for(int i=0;i<m;i++){
            res[i]=new int[n];
            Array.Fill(res[i],int.MaxValue);
        }
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(mat[i][j]==0){
                    q.Enqueue((i,j));
                    res[i][j]=0;
                }
            }
        }
        var dir = new int[]{0,1,0,-1,0};
        while(q.Count>0){
            var a = q.Dequeue();
            var ai = a.Item1;
            var aj = a.Item2;
            for(int i=0;i<4;i++){
                var nai = ai+dir[i];
                var naj = aj+dir[i+1];
                if(nai<0||naj<0||nai>=m||naj>=n){
                    continue;
                }else{
                    if(res[nai][naj]>1+res[ai][aj]){
                        res[nai][naj]=1+res[ai][aj];
                        q.Enqueue((nai,naj));
                    }
                }
            }
        }
        return res;
    }
}