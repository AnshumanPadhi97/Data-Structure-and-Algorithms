public class Solution {
    public int[] SumZero(int n) {
        var res = new List<int>();
        int l = n/2;
        for(int i=-l;i<=l;i++){
            res.Add(i);
        }
        if(n%2==0){
            res.Remove(0);
        }
        return res.ToArray();
    }
}