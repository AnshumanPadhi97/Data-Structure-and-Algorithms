public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        int i=0,j=0,l=nums.Length;
        double res=int.MinValue,curr=0.0;
        while(j<l){
            curr+=nums[j++];
            while(j-i+1>k){
                res=Math.Max(res,curr/k);
                curr-=nums[i++];
            }
        }
        return res;
    }
}