class Solution {
public:
    int build(unordered_map<char,vector<char>>& g,vector<int>& indegree,vector<string>& words){
        for (auto &&w : words)
        {
            for (auto &&ch : w)
            {
                g[ch] = {};
            }            
        }
        for (int i = 1; i < words.size(); i++)
        {
            string first = words[i-1];
            string second = words[i];
            if(first.size() > second.size() && first.compare(0,second.size(),second) == 0){
                return -1;
            }
            int size = min(first.size(),second.size());
            for (int j = 0; j < size; j++)
            {
                if(first[j]!=second[j]){
                    g[first[j]].push_back(second[j]);
                    indegree[second[j]-'a']++;
                    break;
                }
            }            
        } 
        return 1;             
    }
    string alienOrder(vector<string>& words) {
        unordered_map<char,vector<char>> g;
        vector<int> indegree(26,0);
        
        int ret = build(g,indegree,words);
        if(ret<0) return "";

        queue<char> q;
        for (auto &&i : g)
        {
            if(indegree[i.first-'a']==0){
                q.push(i.first);
            }
        }
        
        string res="";
        while (!q.empty())
        {
            char x = q.front();
            q.pop();
            res+=x;
            if((g.find(x)==g.end()) || g[x].size()==0){
                continue;
            }
            for (auto &&i : g[x])
            {
                indegree[i-'a']--;
                if(indegree[i-'a']==0){
                    q.push(i);
                }   
            }            
        }
        return res.size() == g.size() ? res : "";
    }
};