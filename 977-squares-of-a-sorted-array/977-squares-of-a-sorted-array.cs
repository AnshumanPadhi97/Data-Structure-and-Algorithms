public class Solution {
    public int[] SortedSquares(int[] nums) {
        int l = nums.Length;
        var res = new int[l];
        int i=0,j=l-1;
        for(int k=l-1;k>=0;k--){
            if(Math.Abs(nums[i])>Math.Abs(nums[j])){
                res[k]=Math.Abs(nums[i])*Math.Abs(nums[i]);
                i++;
            }else{
                res[k]=Math.Abs(nums[j])*Math.Abs(nums[j]);
                j--;
            }
        }
        return res;
    }
}