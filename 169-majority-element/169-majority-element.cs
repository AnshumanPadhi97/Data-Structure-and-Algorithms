public class Solution {
    public int MajorityElement(int[] nums) {
        int l=nums.Length;
        var d = new Dictionary<int,int>();
        foreach(var item in nums){
            if(!d.ContainsKey(item)){
                d.Add(item,0);
            }
            d[item]++;
        }
        return d.Where(x=>x.Value>l/2).First().Key;
    }
}