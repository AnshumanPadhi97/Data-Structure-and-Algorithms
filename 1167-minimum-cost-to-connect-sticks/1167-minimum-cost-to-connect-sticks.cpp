class Solution {
public:
    int connectSticks(vector<int>& sticks) {
        priority_queue<int,vector<int>,greater<int>> q;
        for (int i = 0; i < sticks.size(); i++)
        {
            q.push(sticks[i]);
        }
        int res=0;
        while (q.size()>1)
        {
            int a = q.top();
            q.pop();
            int b = q.top();
            q.pop();
            int c = a+b;
            res+=c;
            q.push(c);
        }
        return res;
    }
};