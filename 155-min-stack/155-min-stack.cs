public class MinStack {
    Stack<(int,int)> st = new Stack<(int,int)>();
    public MinStack() {
        
    }
    
    public void Push(int val) {
        if(st.Count==0){
            st.Push((val,val));
        }else{
            var min = GetMin();
            st.Push((val,Math.Min(min,val)));
        }
    }
    
    public void Pop() {
        st.Pop();
    }
    
    public int Top() {
        return st.Peek().Item1;
    }
    
    public int GetMin() {
        return st.Peek().Item2;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */