public class Solution {
    public int Search(int[] nums, int target) {
        int l = nums.Length;
        int lo=0,hi=l-1;
        while(lo<=hi){
            var mid = (hi+lo)>>1;
            if(nums[mid]==target){
                return mid;
            }
            else if(nums[mid]>target){
                hi=mid-1;
            }else{
                lo=mid+1;
            }
        }
        return -1;
    }
}