public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int res=int.MaxValue,curr=0;
        int i=0,j=0,l=nums.Length;
        while(j<l){
            curr+=nums[j++];
            while(i<l && curr>=target){
                res=Math.Min(res,j-i);
                curr-=nums[i++];
            }
        }
        return res == int.MaxValue ? 0 : res;
    }
}