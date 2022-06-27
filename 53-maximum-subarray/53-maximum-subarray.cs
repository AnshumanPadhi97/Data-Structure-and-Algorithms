public class Solution {
    public int MaxSubArray(int[] nums) {
        var curr=0;
        var res = int.MinValue;
        foreach(var item in nums){
            curr+=item;
            res=Math.Max(res,curr);
            if(curr<0)curr=0;
        }
        return res;
    }
}