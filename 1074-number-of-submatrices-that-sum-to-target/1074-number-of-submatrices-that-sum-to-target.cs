public class Solution {
    public int NumSubmatrixSumTarget(int[][] matrix, int target) {
            int rows = matrix.Length, cols = matrix[0].Length, i, j, result = 0;
            // calculate prefix Sum for 2D array
            int[,] prefixSum = new int[rows, cols];
            for (i = 0; i < rows; i++)
                for (j = 0; j < cols; j++)
                    prefixSum[i, j] = (j > 0 ? prefixSum[i, j - 1] : 0) + matrix[i][j];

            Dictionary<int, int> sumFrequency = new Dictionary<int, int>();
            for (int c1 = 0; c1 < cols; c1++)
            {
                int[] combinedRowSum = new int[rows];
                for (int c2 = c1; c2 < cols; c2++)
                {
                    // find the total sum for each rth row in this sub-matrix
                    for (int r = 0; r < rows; r++)
                        combinedRowSum[r] = prefixSum[r, c2] - (c1 > 0 ? prefixSum[r, c1 - 1] : 0);


                    // count 'Sub-Matrices' whose sum match 'target'
                    sumFrequency.Clear();
                    sumFrequency.Add(0, 1);     // base case
                    int runningSum = 0, targetSum;

                    for (int r = 0; r < rows; r++)
                    {
                        runningSum += combinedRowSum[r];
                        targetSum = runningSum - target;

                        if (sumFrequency.ContainsKey(targetSum))
                            result += sumFrequency[targetSum];
                        if (!sumFrequency.ContainsKey(runningSum))
                            sumFrequency[runningSum] = 1;
                        else
                            sumFrequency[runningSum]++;
                    }
                }
            }
            return result;
    }
}