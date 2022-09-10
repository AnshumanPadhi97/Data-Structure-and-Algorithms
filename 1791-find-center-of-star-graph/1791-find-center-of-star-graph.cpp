class Solution {
public:
    int findCenter(vector<vector<int>>& edges) {
        int n=edges.size();
        map<int,int> m;
        for (auto &&i : edges)
        {
            m[i[0]]++;
            m[i[1]]++;
        }
        int res;
        for (auto &&i : m)
        {
            if(i.second==n)return i.first;
        }        
        return res;
    }
};