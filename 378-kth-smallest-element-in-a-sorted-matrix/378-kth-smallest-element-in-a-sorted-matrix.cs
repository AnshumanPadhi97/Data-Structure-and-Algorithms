public class Solution {
    public int KthSmallest(int[][] matrix, int k) {
        int n = matrix.Length;
        var ls = new List<int>();
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                ls.Add(matrix[i][j]);
            }
        }
        ls.Sort();
        return ls[k-1];
    }
}