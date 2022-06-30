public class Solution {
    public int[] SumZero(int n) {
            var res = new List<int>();

            for (int i = 1; i <= n / 2; i++)
            {
                res.Add(i);
                res.Add(-i);
            }
            if (n % 2 != 0)
            {
                res.Add(0);
            }
            
            return res.ToArray();
    }
}