public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int l = nums.Length;
        int r = nums[0]+nums[1]+nums[l-1];
        Array.Sort(nums);
        for(int i=0;i<l-1;i++){
            if(i==0 || (i>0 && nums[i]!=nums[i-1])){
                int lo=i+1,hi=l-1;
                while(lo<hi){
                    int x= nums[i]+nums[lo]+nums[hi];
                    if(x>target){
                        hi--;
                    }else{
                        lo++;
                    }
                    if(Math.Abs(x-target)<Math.Abs(r-target)){
                        r=x;
                    }
                }
            }
        }
        return r;
    }
}