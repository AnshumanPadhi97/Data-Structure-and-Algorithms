void Dijkstra(int s,int n, vector<ll>& dist, vector<int>& parent, vector<pair<int,ll>>* g){
    dist.assign(n, INF64);
	parent.assign(n, -1);
	dist[s] = 0;
	priority_queue <pair<ll, ll>, vector<pair<ll, ll>>, greater<pair<ll, ll>>> q;
	q.push({0, s});
	while (!q.empty()) {
		pair<ll, int> a = q.top();
		q.pop();
		int u = a.second;
		ll d = a.first;
		if (d != dist[u]){
			continue;
        }
        for (auto v : g[u]) {
            if (dist[v.first] > dist[u]+v.second) {
                dist[v.first] = dist[u] + v.second;
                parent[v.first] = u;
                q.push({dist[v.first], v.first});
            }
        }
	}
}