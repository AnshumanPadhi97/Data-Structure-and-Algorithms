public class Solution {
    public int MaximumGroups(int[] grades) {
        int k = 0, total = 0, n = grades.Length;
        while (total + k + 1 <= n)
            total += ++k;
        return k;
    }
}