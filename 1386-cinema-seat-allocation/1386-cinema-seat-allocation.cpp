class Solution {
public:
    int maxNumberOfFamilies(int n, vector<vector<int>>& reservedSeats) {
        unordered_map<int,int> m;
        for (auto &&r : reservedSeats)
        {
            m[r[0]]+=(1<<r[1]);
        }
        int res=0;
        for (auto &&i : m)
        {
            int c=0;
            if((i.second & 0b0000111100)==0){
                c++;
            }
            if((i.second & 0b1111000000)==0){
                c++;
            }
            if((i.second & 0b0011110000)==0 && c==0){
                c=1;
            }
            res+=c;
        }        
        return res+2*(n-m.size());
    }
};