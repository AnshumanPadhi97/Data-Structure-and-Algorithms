public class Solution {
    IList<IList<int>> res = new List<IList<int>>();
    public IList<IList<int>> CombinationSum(int[] c, int target) {
        h(c,target,new List<int>(),0);
        return res;
    }
    public void h(int[] nums,int target,List<int> temp,int start){
        if(target<0)return;
        if(target==0){
            res.Add(temp.ToList());
            return;
        }
        for(int i=start;i<nums.Length;i++){
            temp.Add(nums[i]);
            h(nums,target-nums[i],temp,i);
            temp.RemoveAt(temp.Count-1);
        }
    }
}