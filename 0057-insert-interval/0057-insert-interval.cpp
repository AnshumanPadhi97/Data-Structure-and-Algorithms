class Solution {
public:
    vector<vector<int>> insert(vector<vector<int>>& intervals, vector<int>& newInterval) {
        sort(intervals.begin(),intervals.end(),[](vector<int>& a,vector<int>&b){
            return a[0]<b[0];
        });
        
        vector<vector<int>> res;
        int i=0;
        int l = intervals.size();
        
        while (i<l && intervals[i][1]<newInterval[0])
        {
            res.push_back(intervals[i]);
            i++;
        }
        
        while (i<l && intervals[i][0] <= newInterval[1])
        {
            newInterval[0] = min(intervals[i][0],newInterval[0]);
            newInterval[1] = max(intervals[i][1],newInterval[1]);
            i++;
        }        
        
        res.push_back(newInterval);
        
        while (i<l)
        {
            res.push_back(intervals[i]);
            i++;
        }
        return res;
    }
};