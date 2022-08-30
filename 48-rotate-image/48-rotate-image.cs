public class Solution {
    public void Rotate(int[][] matrix) {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i; j < matrix[0].Length; j++)
                {
                    var a = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = a;
                }
            }
            int m = matrix.Length;
            int n = matrix[0].Length;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m/2; j++)
                {
                    var a = matrix[i][j];
                    matrix[i][j] = matrix[i][m - 1 - j];
                    matrix[i][m - 1 - j] = a;
                }
            }
    }
}