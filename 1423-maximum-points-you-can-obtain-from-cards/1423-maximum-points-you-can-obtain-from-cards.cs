public class Solution {
    public int MaxScore(int[] cardPoints, int k) {
        int n = cardPoints.Length; 
        int lSum = cardPoints.Take(k).Sum();
        int max = lSum;
        for (int rSum = 0, i = 0; i < k; ++i)
        {
            rSum += cardPoints[n - 1 - i];
            lSum -= cardPoints[k - 1 - i];
            max = Math.Max(max, lSum + rSum);
        }
        return max;
    }
}