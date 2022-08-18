public class Solution {
    public int Search(int[] nums, int target) {
        int i=0,j=nums.Length-1;
        while(i<j){
            var mid = (i+j)>>1;
            if(nums[mid]==target){
                return mid;
            }
            if(nums[i]<=nums[mid]){
                if(target>=nums[i] && target<=nums[mid]){
                    j=mid-1;
                }else{
                    i=mid+1;
                }
            }else{
                if(target>nums[mid] && target<=nums[j]){
                    i=mid+1;
                }else{
                    j=mid-1;
                }
            }
        }
        return nums[i]==target?i:-1;
    }
}