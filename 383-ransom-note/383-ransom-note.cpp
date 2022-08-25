class Solution {
public:
    bool canConstruct(string a, string b) {
        map<char,int> m;
        for(auto i:b){
            m[i]++;
        }
        for(auto i:a){
            if(m[i]>0){
                m[i]--;
            }else{
                return false;
            }
        }
        return true;
    }
};