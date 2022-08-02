public class Solution {
    public int MinimumOperations(int[] nums) {
        return nums.Where(x=>x>0).ToHashSet().Count;
    }
}