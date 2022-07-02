public class Solution {
    public int LongestConsecutive(int[] nums) {
        Array.Sort(nums);
        int l = nums.Length;
        if(l==0)return 0;
        int res=1,curr=1;
        for(int i=1;i<l;i++){
            if(nums[i]!=nums[i-1]){
                if(nums[i]==nums[i-1]+1){
                    curr+=1;
                }else{
                    res=Math.Max(res,curr);
                    curr=1;
                }
            }
        }
        return Math.Max(res,curr);
    }
}