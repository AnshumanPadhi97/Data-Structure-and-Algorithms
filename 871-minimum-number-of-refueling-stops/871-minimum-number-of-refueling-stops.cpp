class Solution {
public:
    int minRefuelStops(int target, int startFuel, vector<vector<int>>& stations) {
        int res=0;
        priority_queue<int> q;
        for (auto &&i : stations)
        {
            while (startFuel<i[0] && q.size())
            {
                startFuel+=q.top();
                q.pop();
                res++;
            }
            if(startFuel<i[0])return -1;
            q.push(i[1]);
        }
        while (startFuel< target && q.size())
        {
            startFuel+=q.top();
            q.pop();
            res++;
        }
        if(startFuel<target)return -1;
        return res;
    }
};