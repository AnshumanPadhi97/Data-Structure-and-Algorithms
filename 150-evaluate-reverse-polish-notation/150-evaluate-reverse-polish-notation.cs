public class Solution {
    public int EvalRPN(string[] tokens) {
            var st = new Stack<int>();
            foreach (var item in tokens)
            {
                if(item == "+")
                {
                    st.Push(st.Pop() + st.Pop());
                }
                else if(item == "-")
                {
                    var a = st.Pop();
                    var b = st.Pop();
                    st.Push(b - a);
                }
                else if(item == "*")
                {
                    var a = st.Pop();
                    var b = st.Pop();
                    st.Push(a * b);
                }
                else if(item == "/")
                {
                    var a = st.Pop();
                    var b = st.Pop();
                    st.Push(b / a);
                }
                else
                {
                    st.Push(int.Parse(item));
                }
            }
            return st.Pop();
    }
}