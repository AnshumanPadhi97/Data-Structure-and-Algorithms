public class Solution {
    public int MaxSubArray(int[] nums) {
        int res= int.MinValue;
        int curr=0;
        foreach(var item in nums){
            curr+=item;
            res=Math.Max(res,curr);
            if(curr<0)curr=0;
        }
        return res;
    }
}