public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        int res=0,i=0,j=0,l=nums.Length;
        if(k<=1)return 0;
        var temp=1;
        while(j<l){
            temp*=nums[j++];
            while(i<l && temp>=k){
                temp/=nums[i++];
            }
            res+=j-i;
        }
        return res;
    }
}