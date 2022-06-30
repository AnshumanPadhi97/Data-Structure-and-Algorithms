public class Solution {
    public void SetZeroes(int[][] matrix) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        var l = new HashSet<int>();
        var r = new HashSet<int>();
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(matrix[i][j]==0){
                    l.Add(i);
                    r.Add(j);
                }
            }
        }
         for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(l.Contains(i) || r.Contains(j)){
                    matrix[i][j]=0;
                }
            }
         }
    }
}