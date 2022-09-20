class Solution {
public:
    string removeDuplicates(string s, int k) {
        stack<int> st;
        for (int i = 0; i < s.size(); i++)
        {
            if(i==0 || s[i]!=s[i-1]){
                st.push(1);          //normally push 1
            }else{
                st.top()++;      //increment same char freq
                if(st.top()==k){     //if freq == k
                    st.pop();       //pop
                    s.erase(i-k+1,k);    //erase from string
                    i-=k;
                }
            }
        }
        return s;
    }
};