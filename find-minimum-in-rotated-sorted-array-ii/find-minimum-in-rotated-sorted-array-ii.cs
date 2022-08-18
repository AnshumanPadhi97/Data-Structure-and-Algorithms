public class Solution {
    public int FindMin(int[] nums) {
        int j = nums.Length-1;
        int i=0;
        while(i<j){
            var mid = (i+j)>>1;
            if(nums[mid]<nums[j]){
                j=mid;
            }
            else if(nums[mid]>nums[j]){
                i=mid+1;
            }else{
                j--;//same element so just decrease pointer
            }
        }
        return nums[i];
    }
}