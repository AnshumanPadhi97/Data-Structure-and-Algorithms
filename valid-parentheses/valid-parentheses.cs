public class Solution {
    public bool IsValid(string s) {
        var st=new Stack<char>();
        for(int i=0;i<s.Length;i++){
            if(s[i]=='}'){
                if(st.Count>0 && st.Peek() == '{'){
                    st.Pop();
                }else{
                    return false;
                }
            }
            else if(s[i]==')'){
                if(st.Count>0 && st.Peek() == '('){
                    st.Pop();
                }else{
                    return false;
                }
            }
            else if(s[i]==']'){
                if(st.Count>0 && st.Peek() == '['){
                    st.Pop();
                }else{
                    return false;
                }
            }
            else{
                st.Push(s[i]);
            }
        }
        return st.Count==0;
    }
}