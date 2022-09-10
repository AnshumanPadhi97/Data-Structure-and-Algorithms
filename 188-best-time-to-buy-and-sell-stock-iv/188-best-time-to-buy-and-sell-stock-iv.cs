public class Solution {
    public int MaxProfit(int k, int[] prices) {
        int l = prices.Length;
        if(l<2 || k<1)return 0;
        
        var buy = new int[k];
        Array.Fill(buy,int.MinValue);
        var sell = new int[k];
        
        int res=0;
        if(k>l/2){
            res=0;
            for(int i=1;i<l;i++){
                res+=Math.Max(0,prices[i]-prices[i-1]);
            }
            return res;
        }
        
        for(int i=0;i<l;i++){
            for(int j=0;j<k;j++){
                buy[j]=Math.Max(buy[j],( j>0 ? sell[j-1] : 0) - prices[i]);
                sell[j]=Math.Max(sell[j],buy[j]+prices[i]);
            }
        }
        
        return sell[k-1];
    }
}