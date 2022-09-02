class Solution {
public:
    int longestValidParentheses(string s) {
        int l=0,r=0;
        int n = s.size();
        int res=0;
        for(int i=0;i<n;i++){
            if(s[i]=='(')l++;
            else r++;
            if(l==r){
                res=max(res,2*l);
            }
            if(r>l)l=r=0;
        }
        l=r=0;
        for(int i=n-1;i>=0;i--){
            if(s[i]=='(')l++;
            else r++;
            if(l==r){
                res=max(res,2*l);
            }
            if(l>r)l=r=0;
        }
        return res;
    }
};