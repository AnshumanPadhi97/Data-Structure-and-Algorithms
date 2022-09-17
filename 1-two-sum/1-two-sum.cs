public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var h = new HashSet<int>();
        for(int i=0;i<nums.Length;i++){
            if(h.Contains(target-nums[i])){
                return new int[]{i,Array.IndexOf(nums,target-nums[i])};
            }else{
                h.Add(nums[i]);
            }
        }
        return new int[]{0,0};
    }
}