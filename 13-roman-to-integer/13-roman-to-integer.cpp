class Solution {
public:
    int romanToInt(string s) {
        int l = s.size();
        int res=0;
        map<int,int> m;
        m['I']=1;
        m['V']=5;
        m['X']=10;
        m['L']=50;
        m['C']=100;
        m['D']=500;
        m['M']=1000;
        res=m[s[l-1]];
        for(int i=l-2;i>=0;i--){
            if(m[s[i]]<m[s[i+1]]){
                res-=m[s[i]];
            }else{
                res+=m[s[i]];
            }
        }
        return res;
    }
};