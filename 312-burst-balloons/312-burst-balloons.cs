public class Solution {
    int[,] dp = new int[301,301];
    public int MaxCoins(int[] nums) {
        int l=nums.Length+2;
        dp=new int[l,l];
        int[] arr = new int[l];
        arr[0]=1;
        arr[l-1]=1;
        for(int i=1;i<l-1;i++)arr[i]=nums[i-1];
        return h(arr,0,l-1);
    }
    public int h(int[] nums, int i,int j){
        if(i+1==j){
            return 0;
        }
        if(dp[i,j]>0)return dp[i,j];
        int res=0;
        for(int k=i+1;k<j;k++){
            var a = h(nums,i,k)+h(nums,k,j)+(nums[i]*nums[k]*nums[j]);
            res=Math.Max(res,a);
        }
        return dp[i,j]=res;
    }
}