public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        int l=nums.Length;
        var ls = new HashSet<int>();
        for(int i=0;i<l;i++){
            if(!ls.Add(nums[i])){
                return true;
            }
            if(ls.Count>k){
                ls.Remove(nums[i-k]);
            }
        }
        return false;
    }
}