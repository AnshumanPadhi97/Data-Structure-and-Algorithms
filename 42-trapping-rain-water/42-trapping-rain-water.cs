public class Solution {
    public int Trap(int[] h) {
        var st = new Stack<int>();
        int l = h.Length;
        int res=0;
        for(int i=0;i<l;i++){
            while(st.Count>0 && h[st.Peek()]<h[i]){
                int bottom = h[st.Pop()];
                if(st.Count==0)break;
                int left = st.Peek();
                var w = (i-left-1)*(Math.Min(h[left],h[i])-bottom);
                res+=w;
            }
            st.Push(i);
        }
        return res;
    }
}