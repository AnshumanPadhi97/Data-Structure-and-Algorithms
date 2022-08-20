public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
            int n = gas.Length;
            int a = 0, b = 0, start = 0;
            for (int i = 0; i < n; i++)
            {
                a += gas[i] - cost[i];
                b += gas[i] - cost[i];
                if (b < 0)
                {
                    b = 0;
                    start = i + 1;
                }
            }
            return a < 0 ? -1 : start;
    }
}