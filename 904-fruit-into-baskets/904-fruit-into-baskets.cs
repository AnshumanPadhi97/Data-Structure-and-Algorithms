public class Solution {
    public int TotalFruit(int[] f) {
        var d = new Dictionary<int,int>();
        int i=0,res=0,j=0,l=f.Length;
        while(j<l){
            if(d.ContainsKey(f[j])){
                d[f[j]]++;
            }else{
                d.Add(f[j],1);
            }
            j++;
            while(i<l && d.Count>2){
                d[f[i]]-=1;
                if(d[f[i]]==0)
                    d.Remove(f[i]);
                i++;
            }
            res=Math.Max(res,j-i);
        }
        return res;
    }
}