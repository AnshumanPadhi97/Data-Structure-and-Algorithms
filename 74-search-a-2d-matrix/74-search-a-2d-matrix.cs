public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
            int lo = 0, hi = matrix[0].Length-1;
            while (lo<matrix.Length && hi>=0)
            {
                if (matrix[lo][hi] == target)
                {
                    return true;
                }
                else if (matrix[lo][hi]>target)
                {
                    hi--;
                }
                else
                {
                    lo++;
                }
            }
            return false;
    }
}