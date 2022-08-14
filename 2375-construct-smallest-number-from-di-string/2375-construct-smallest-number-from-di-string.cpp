class Solution {
public:
    bool check(string& s,string& t){
        for (int i = 1; i < t.size(); i++)
        {
            if(t[i]>t[i-1] && s[i-1]!='I')return false;
            if(t[i]<t[i-1] && s[i-1]!='D')return false;
        }
        return true;
    }

string smallestNumber(string s) {
        string t ="";
        string res="";
        for (int i = 1; i <= s.size()+1; i++)
        {
            t+=to_string(i);
        }
        do
        {
            if(check(s,t)){
                if(res.size()==0)res=t;
                else res = min(res,t);
            }
        } while (next_permutation(t.begin(),t.end()));
        return res;
    }
};