public class Solution {
    public int[] DailyTemperatures(int[] t) {
        var st = new Stack<int>();
        int l = t.Length;
        var res = new int[l];
        for(int i=0;i<l;i++){
            while(st.Count>0 && t[st.Peek()]<t[i]){
                var a=st.Pop();
                res[a]=i-a;
            }
            st.Push(i);
        }
        return res;
    }
}