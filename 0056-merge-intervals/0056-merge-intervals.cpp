class Solution {
public:
    vector<vector<int>> merge(vector<vector<int>>& intervals) {
        sort(intervals.begin(),intervals.end(),[](auto a,auto b){
            return a[0]<b[0];
        });
        vector<vector<int>> res;
        res.push_back(intervals[0]);
        int j=0;
        for (int i = 1; i < intervals.size(); i++)
        {
            if(intervals[i][0]<=res[j][1]){
                res[j][1] = max(intervals[i][1],res[j][1]);
            }else{
                res.push_back(intervals[i]);
                j++;
            }
        }        
        return res;
    }
};