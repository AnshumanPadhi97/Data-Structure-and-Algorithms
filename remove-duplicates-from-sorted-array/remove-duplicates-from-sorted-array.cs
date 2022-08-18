public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int l = nums.Length;
        int j=1;
        for(int i=1;i<l;i++){
            if(nums[i]!=nums[i-1]){
                nums[j++]=nums[i];
            }
        }
        return j;
    }
}