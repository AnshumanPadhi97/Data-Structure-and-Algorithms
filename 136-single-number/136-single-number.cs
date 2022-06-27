public class Solution {
    public int SingleNumber(int[] nums) {
        var res=0;
        foreach(var item in nums){
            res^=item;
        }
        return res;
    }
}