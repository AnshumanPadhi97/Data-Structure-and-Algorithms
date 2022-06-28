public class Solution {
    IList<IList<int>> res = new List<IList<int>>();
    public IList<IList<int>> Permute(int[] nums) {
        h(nums,new List<int>());
        return res;
    }
    public void h(int[] nums,List<int> temp){
        if(temp.Count==nums.Length){
            res.Add(temp.ToList());return;
        }
        foreach(var item in nums){
            if(!temp.Contains(item)){
                temp.Add(item);
                h(nums,temp);
                temp.RemoveAt(temp.Count-1);
            }
        }
    }
}