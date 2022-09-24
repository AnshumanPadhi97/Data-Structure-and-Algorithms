class Solution {
public:
    int meetRequirement(int n, vector<vector<int>>& l, vector<int>& r) {
        vector<int> m(n+1,0);
        for(auto i:l)
        {
            m[max(0,i[0]-i[1])]++;
            m[min(n,i[0]+i[1]+1)]--;
        }
        int b=0,res=0;
        for(int i=0;i<n;i++){
            b+=m[i];
            if(b>=r[i]){
                res++;
            }
        }
        return res;
    }
};