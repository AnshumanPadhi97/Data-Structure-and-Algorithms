class Solution {
public:
    int minGroups(vector<vector<int>>& intervals) {
        sort(begin(intervals),end(intervals));
        priority_queue<int,vector<int>,greater<int>> q;
        for (auto &&i : intervals)
        {
            if(!q.empty() && q.top()<i[0]){
                q.pop();
            }
            q.push(i[1]);
        }
        return q.size();
    }
};