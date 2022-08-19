public class Solution {
    public bool CanJump(int[] nums) {
        int curr=0;
        for(int i=0;i<nums.Length;i++){
            if(curr<i){return false;}
            curr=Math.Max(curr,i+nums[i]);
        }
        return true;
    }
}