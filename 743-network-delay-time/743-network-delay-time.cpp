class Solution {
public:
    int networkDelayTime(vector<vector<int>>& times, int n, int k) {
        vector<vector<pair<int,int>>> g(n+1);
        for (auto &&i : times)
        {
            g[i[0]].push_back({i[1],i[2]});
        }

        vector<int> dist(n+1,INT_MAX);

        priority_queue<pair<int,int>,vector<pair<int,int>>,greater<pair<int,int>>> q;
        dist[k]=0;

        q.push({0,k});

        while (!q.empty())
        {
            int u = q.top().second;
            q.pop();

            for (auto &&i : g[u])
            {
                if(dist[i.first]>dist[u]+i.second){
                    dist[i.first]=dist[u]+i.second;
                    q.push({dist[i.first],i.first});
                }       
            }        
        }
        int res =*max_element(dist.begin()+1,dist.end());
        return res == INT_MAX ? -1 : res;
    }
};