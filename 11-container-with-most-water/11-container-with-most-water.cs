public class Solution {
    public int MaxArea(int[] h) {
        int i=0,j=h.Length-1,res=0;
        res=Math.Min(h[i],h[j])*(j-i);
        while(i<j){
            if(h[i]<h[j]){
                i++;
            }else{
                j--;
            }
            res=Math.Max(res,Math.Min(h[i],h[j])*(j-i));
        }
        return res;
    }
}