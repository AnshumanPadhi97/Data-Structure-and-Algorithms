public class Solution {
    public int FindMaxLength(int[] nums) {
        var d = new Dictionary<int,int>();
        int res=0,cur=0;
        d.Add(0,-1);
        for(int i=0;i<nums.Length;i++){
            cur+=nums[i]==1?1:-1;
            if(d.ContainsKey(cur)){
                res=Math.Max(res,i-d[cur]);
            }else{
                d.Add(cur,i);
            }
        }
        return res;
    }
}