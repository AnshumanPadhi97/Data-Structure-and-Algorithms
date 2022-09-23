class Solution {
public:
    vector<int> sumZero(int n) {
        vector<int> res;
        if(n == 0) return res;
        if(n%2!=0){
            res.push_back(0);
        }
        for(int i=-n/2;i<=n/2;i++){
            if(i==0)continue;
            res.push_back(i);
        }
        return res;
    }
};