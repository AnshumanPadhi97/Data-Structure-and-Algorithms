public class Solution {
    public int Trap(int[] h) {
        var st = new Stack<int>();
        int res=0;
        int p = h.Length;
        for(int i=0;i<p;i++){
            while(st.Count>0 && h[st.Peek()]<h[i]){
                int b = st.Peek();
                st.Pop();
                if(st.Count==0)break;
                int l = st.Peek();
                int w = (i-l-1)*(Math.Min(h[l],h[i])-h[b]);
                res+=w;
            }
            st.Push(i);
        }
        return res;
    }
}