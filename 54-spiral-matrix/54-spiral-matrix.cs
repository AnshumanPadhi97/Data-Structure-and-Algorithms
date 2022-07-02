public class Solution {
    public IList<int> SpiralOrder(int[][] mat) {
        var res = new List<int>();
        int m = mat.Length;
        int n = mat[0].Length;
        int ra=0,rb=m-1,ca=0,cb=n-1;
        while(ra<=rb && ca<=cb){
            for(int j=ca;j<=cb;j++){
                res.Add(mat[ra][j]);
            }
            ra++;
            for(int i=ra;i<=rb;i++){
                res.Add(mat[i][cb]);
            }
            cb--;
            if(ra<=rb){
                for(int j=cb;j>=ca;j--){
                    res.Add(mat[rb][j]);
                }   
            }
            rb--;
            if(ca<=cb){
                for(int i=rb;i>=ra;i--){
                    res.Add(mat[i][ca]);
                }
            }
            ca++;
        }
        return res;
    }
}