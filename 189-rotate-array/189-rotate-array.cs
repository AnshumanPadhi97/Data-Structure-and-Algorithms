public class Solution {
    public void Rotate(int[] nums, int k) {
        int l=nums.Length;
        k%=l;
        rev(nums,0,l-1);
        rev(nums,0,k-1);
        rev(nums,k,l-1);
    }
    public void rev(int[] nums,int a,int b){
        while(a<=b){
            var temp = nums[b];
            nums[b]=nums[a];
            nums[a]=temp;
            a++;
            b--;
        }
    }
}