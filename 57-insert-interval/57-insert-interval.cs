public class Solution {
    public int[][] Insert(int[][] a, int[] b) {
        var res=  new List<int[]>();
        int i=0,l=a.Length;
        while(i<l && a[i][1]<b[0]){
            res.Add(a[i++]);
        }
        while(i<l && a[i][0]<=b[1]){
            b[0]=Math.Min(a[i][0],b[0]);
            b[1]=Math.Max(a[i][1],b[1]);
            i++;
        }
        res.Add(b);
        while(i<l){
            res.Add(a[i++]);
        }
        return res.ToArray();
    }
}