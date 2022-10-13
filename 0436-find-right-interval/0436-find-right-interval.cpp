class Solution {
public:
    vector<int> findRightInterval(vector<vector<int>>& intervals) {
        vector<int> res;
        map<int,int> m;
        int l = intervals.size();
        for (int i = 0; i < l; i++)
        {
            m[intervals[i][0]]=i;
        }
        for(auto a:intervals){
            int end=a[1];
            auto it = m.lower_bound(end);
            if(it==m.end()){
                res.push_back(-1);
            }else{
                res.push_back(it->second);
            }
        }
        return res;
    }
};