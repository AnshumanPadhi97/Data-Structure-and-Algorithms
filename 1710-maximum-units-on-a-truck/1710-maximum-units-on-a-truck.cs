public class Solution {
    public int MaximumUnits(int[][] boxTypes, int truckSize) {
            var res = 0;
            var c = truckSize;
            Array.Sort(boxTypes, (a, b) => b[1].CompareTo(a[1]));
            for (int i = 0; i < boxTypes.Length; i++)
            {
                if(boxTypes[i][0] <= c)
                {
                    c -= boxTypes[i][0];
                    res+=boxTypes[i][0] * boxTypes[i][1];
                }
                else
                {
                    res += c * boxTypes[i][1];c = 0;
                }
            }
            return res;
    }
}