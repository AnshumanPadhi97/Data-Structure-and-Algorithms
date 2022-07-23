public class Solution {
    public int ThreeSumSmaller(int[] nums, int target) {
        Array.Sort(nums);
        int res=0;
        for(int k=0;k<nums.Length-2;k++){
            var i = k+1;
            var j = nums.Length-1;
            while(i<j){
                var s = nums[k]+nums[i]+nums[j];
                if(s<target){
                    res+=j-i;
                    i++;
                }else{
                    j--;
                }
            }
        }
        return res;
    }
}