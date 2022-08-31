class Solution {
public:
    vector<string> findAllRecipes(vector<string>& recipes, vector<vector<string>>& ingredients, vector<string>& supplies) {
	unordered_map<string,vector<string>> g;
	unordered_set<string> s;
	for (auto &&i : supplies)
	{
		s.insert(i);
	}
	
	unordered_map<string,int> indegree;
	for (auto &&i : recipes)
	{
		indegree[i]=0;
	}
	
	for (int i = 0; i < recipes.size(); i++)
	{
		for (int j = 0; j < ingredients[i].size(); j++)
		{
			if(s.find(ingredients[i][j])==s.end()){
				g[ingredients[i][j]].push_back(recipes[i]);
				indegree[recipes[i]]++;
			}
		}		
	}
	
	queue<string> q;
	for (auto &&i : indegree)
	{
		if(i.second==0){
			q.push(i.first);
		}
	}
	
	vector<string>res;
	
	while (!q.empty())
	{
		string a = q.front();
		q.pop();
		res.push_back(a);
		for (auto &&i : g[a])
		{
			indegree[i]--;
			if(indegree[i]==0){
				q.push(i);
			}
		}		
	}	

	return res;
        
    }
};