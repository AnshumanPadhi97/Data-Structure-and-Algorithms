public class Solution {
    public int NumPairsDivisibleBy60(int[] time) {
        int c = 0;
        var b = new int[60];
        foreach (var item in time)
        {
            var a = item % 60;
            if (a == 0)
            {
                c += b[0];
            }
            else
            {
                c += b[60 - a];
            }
            b[a]++;
        }
        return c;
    }
}