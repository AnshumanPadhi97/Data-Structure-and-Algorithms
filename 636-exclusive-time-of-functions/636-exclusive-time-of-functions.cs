public class Solution {
    public int[] ExclusiveTime(int n, IList<string> logs) {
        var st = new Stack<(int,int)>();
        var res = new int[n];
        foreach(var item in logs){
            var a = item.Split(':');
            var id = int.Parse(a[0]);
            var time = int.Parse(a[2]);
            var b = a[1];
            if(b=="start"){
                if(st.Count()!=0){
                    res[st.Peek().Item1]+=time-st.Peek().Item2;
                }
                st.Push((id,time));
            }else{
                res[id]+=time-st.Pop().Item2+1;
                if(st.Count()!=0){
                    st.Push((st.Pop().Item1,time+1));
                }
            }
        }
        return res;
    }
}