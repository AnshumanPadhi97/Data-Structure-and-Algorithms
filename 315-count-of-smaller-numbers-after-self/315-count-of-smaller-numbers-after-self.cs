public class Solution {
    public IList<int> CountSmaller(int[] nums)
    {
        int n = nums.Length;
        int[] counts = new int[n];
        var sorted = new List<int>();
        BSComparer comparer = new BSComparer();

        for (int i = n - 1; i >= 0; i--)
        {
            int index = sorted.BinarySearch(nums[i], comparer);
            if (index < 0)
            {
                index = ~index;
            }
            counts[i] = index;
            sorted.Insert(index, nums[i]);
        }
        return counts;
    }
    public class BSComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x == y)
                return 1;
            return x.CompareTo(y);
        }
    }
}