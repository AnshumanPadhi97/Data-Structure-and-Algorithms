public class Solution {
    public int[] SortedSquares(int[] nums) {
        var l = nums.Length;
        var res = new int[l];
        int i=0,j=l-1,k=l-1;
        while(k>=0){
            if(Math.Abs(nums[i])<Math.Abs(nums[j])){
                res[k]=nums[j]*nums[j];
                j--;
            }else{
                res[k]=nums[i]*nums[i];
                i++;
            }
            k--;
        }
        return res;
    }
}