public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var hs = nums.ToHashSet<int>();
        return hs.Count != nums.Length;
    }
}