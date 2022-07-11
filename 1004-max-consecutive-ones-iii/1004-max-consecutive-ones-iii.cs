public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int i=0,res=0,curr=0,l=nums.Length,j=0;
        while(j<l){
            curr+=nums[j++]==0?1:0;
            while(i<l && curr>k){
                curr-=nums[i++]==0?1:0;
            }
            res=Math.Max(res,j-i);
        }
        return res;
    }
}