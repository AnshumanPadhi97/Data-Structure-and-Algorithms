public class Solution {
    public int TriangularSum(int[] nums) {
        if(nums.Length==1)return nums[0];
        int l = nums.Length;
        int[] a = new int[l-1];
        for(int i=0;i<l-1;i++){
            a[i] = (nums[i]+nums[i+1])%10;
        }
        return TriangularSum(a);
    }
}