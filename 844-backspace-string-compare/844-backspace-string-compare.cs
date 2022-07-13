public class Solution {
    public bool BackspaceCompare(string s, string t) {
        var st = new Stack<char>();
        for(int i=0;i<s.Length;i++){
            if(st.Count>0 && s[i]=='#'){
                st.Pop();
            }
            if(s[i]!='#'){
                st.Push(s[i]);
            }
        }
        string p ="";
        while(st.Count>0){
            p+=st.Pop();
        }
        st = new Stack<char>();
        for(int i=0;i<t.Length;i++){
            if(st.Count>0 && t[i]=='#'){
                st.Pop();
            }
            if(t[i]!='#'){
                st.Push(t[i]);
            }
        }
        string q ="";
        while(st.Count>0){
            q+=st.Pop();
        }
        return p.Equals(q);
    }
}