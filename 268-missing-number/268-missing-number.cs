public class Solution {
    public int MissingNumber(int[] nums) {
        var s = nums.Sum();
        int l = nums.Length+1;
        var os = l*(l-1)/2;
        return os-s;
    }
}