public class Solution {
    public int SingleNumber(int[] nums) {
        int res=0;
        foreach(var item in nums)res^=item;
        return res;
    }
}