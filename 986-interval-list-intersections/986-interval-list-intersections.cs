public class Solution {
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList) {
            var res = new List<int[]>();
            int i = 0, j = 0;
            while (i < firstList.Length && j < secondList.Length)
            {
                // Let's check if firstList[i] intersects secondList[j].
                // lo - the startpoint of the intersection
                // hi - the endpoint of the intersection
                var a = Math.Max(firstList[i][0], secondList[j][0]);
                var b = Math.Min(firstList[i][1], secondList[j][1]);
                if (a <= b)
                {
                    res.Add(new int[] { a, b });
                }
                if (firstList[i][1] < secondList[j][1])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            return res.ToArray();
    }
}