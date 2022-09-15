class Solution {
public:
    int repeatedStringMatch(string a, string b) {
        string s="";
        int c=0;
        while (s.size()<b.size())
        {
            s+=a;
            c++;
        }
        if(s.find(b)!=string::npos){
            return c;
        }
        s+=a;
        c++;
        if(s.find(b)!=string::npos){
            return c;
        }
        return -1;
    }
};