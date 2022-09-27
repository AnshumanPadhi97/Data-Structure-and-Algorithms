class Solution {
public:
    int minInsertions(string s) {
        stack<char> st;
        int open=0,close=0;
        for (int i = 0; i < s.size(); i++)
        {
            if(s[i]=='('){
                st.push(s[i]);
            }else{
                if(i<s.size()-1 && s[i+1]==')'){
                    if(!st.empty())st.pop();
                    else open++;
                    i++;
                }else{
                    if(st.empty()){
                        open++;
                        close++;
                    }else{
                        st.pop();
                        close++;
                    }
                }
            }
        }
        return st.size()*2+open+close;
    }
};