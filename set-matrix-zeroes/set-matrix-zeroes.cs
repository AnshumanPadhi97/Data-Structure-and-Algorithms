public class Solution {
    public void SetZeroes(int[][] matrix) {
        var r = new HashSet<int>();
        var c = new HashSet<int>();
        int m = matrix.Length;
        int n = matrix[0].Length;
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(matrix[i][j]==0){
                    r.Add(i);
                    c.Add(j);
                }
            }
        }
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(r.Contains(i) || c.Contains(j)){
                    matrix[i][j]=0;
                }
            }
        }
    }
}