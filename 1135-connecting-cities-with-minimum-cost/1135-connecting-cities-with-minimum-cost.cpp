class Solution {
public:
    int minimumCost(int n, vector<vector<int>>& connections) {
        vector<vector<pair<int,int>>> m(n+1);
        vector<bool> vis(n+1,false);
        vector<int> minCost(n+1,INT_MAX);
        for (auto &&i : connections)
        {
            m[i[0]].push_back({i[2],i[1]});
            m[i[1]].push_back({i[2],i[0]});
        }
        priority_queue<pair<int,int>,vector<pair<int,int>>,greater<pair<int,int>>> q;
        q.push({0,1});
        int numvis = 0, res=0;
        while (numvis<n && !q.empty())
        {
            int cost = q.top().first;
            int city = q.top().second;
            q.pop();
            if(vis[city])continue;
            numvis++;
            res+=cost;
            vis[city]=true;
            for (auto &&i : m[city])
            {
                cost = i.first;
                city = i.second;
                if(!vis[city] && cost<minCost[city]){
                    minCost[city] = cost;
                    q.push({cost,city});
                } 
            }
            
        }
        return numvis == n?res:-1;
    }
};