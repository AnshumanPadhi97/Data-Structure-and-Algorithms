public class Solution {
    public int FindMin(int[] nums) {
        int l = nums.Length;
        int i=0,j=l-1;
        while(i<j){
            var mid = (i+j)>>1;
            if(nums[mid]<nums[j]){
                j=mid;
            }
            else{
                i=mid+1;
            }
        }
        return nums[i];
    }
}