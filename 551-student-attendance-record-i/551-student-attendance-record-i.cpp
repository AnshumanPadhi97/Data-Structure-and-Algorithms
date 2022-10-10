class Solution {
public:
    bool checkRecord(string s) {
        int a = 0;
        for(int i=0;i<s.size()-2 && s.size()>=2;i++){
            if(s[i]=='L' && s[i+1]=='L' && s[i+2]=='L'){
                return false;
            }
        }
        for(int i=0;i<s.size();i++){
            if(s[i]=='A') a++;
        }
        if(a>=2) return false;
        return true;
    }
};