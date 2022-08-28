class Solution {
public:
    int garbageCollection(vector<string>& garbage, vector<int>& travel) {
		int dist[3]={},mins=0;
		partial_sum(travel.begin(),travel.end(),travel.begin());
		for (int i = 0; i < garbage.size(); i++)
		{
			for (auto &&g : garbage[i])
			{
				int id = g == 'M' ? 0 : g == 'P' ? 1 : 2;
				dist[id] = i > 0 ? travel[i-1] : 0;
				mins++;
			}			
		}
		return mins+accumulate(begin(dist),end(dist),0);        
    }
};