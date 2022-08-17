public class Solution {
    public int MaxProfit(int[] p) {
        int res=int.MinValue;
        int min=p[0];
        foreach(var item in p){
            res=Math.Max(res,item-min);
            min=Math.Min(min,item);
        }
        return res;
    }
}