public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] res = new int[2];
        var h = new HashSet<int>();
        for(int i=0;i<nums.Length;i++){
            if(h.Contains(target-nums[i])){
                res[1] = i;
                res[0] = Array.IndexOf(nums,target-nums[i]);
                break;
            }
            h.Add(nums[i]);
        }
        return res;
    }
}