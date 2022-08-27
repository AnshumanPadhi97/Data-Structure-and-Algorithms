class Solution {
public:
    int networkDelayTime(vector<vector<int>>& times, int n, int k) {
        vector<int> dist(n+1,INT_MAX);
        dist[k]=0;
    
        for (int i = 1; i < n; i++)
        {
            for (auto &&i : times)
            {
                int u = i[0], v = i[1], d = i[2];
                if(dist[u] != INT_MAX && dist[v]>dist[u]+d){
                    dist[v]=dist[u]+d;
                }
            }        
        }    

        int res=*max_element(dist.begin()+1,dist.end());
        return res==INT_MAX?-1:res;
    }
};