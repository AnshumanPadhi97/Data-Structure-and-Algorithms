public class Solution {
    public int[][] ReconstructQueue(int[][] people) {
            var res = new List<int[]>();
            Array.Sort(people, (a, b) => a[0] == b[0] ? a[1].CompareTo(b[1]) : b[0].CompareTo(a[0]));
            foreach (var item in people)
            {
                res.Insert(item[1], item);
            }
            return res.ToArray();
    }
}