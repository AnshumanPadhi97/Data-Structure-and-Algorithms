public class Solution {
    public bool IsValid(string s) {
        var st=  new Stack<char>();
        foreach(var item in s){
            if(item==']'){
                if(st.Count>0 && st.Peek() == '['){
                    st.Pop();
                }else{
                    return false;
                }   
            }
            else if(item==')'){
                if(st.Count>0 && st.Peek() == '('){
                    st.Pop();
                }else{
                    return false;
                }
            }
            else if(item=='}'){
                if(st.Count>0 && st.Peek() == '{'){
                    st.Pop();
                }else{
                    return false;
                }
            }else{
                st.Push(item);
            }
        }
        return st.Count==0;
    }
}