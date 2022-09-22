class Solution {
public:
    vector<string> subdomainVisits(vector<string>& cpdomains) {
        unordered_map<string,int> m;
        for (auto &&c : cpdomains)
        {
            int i = c.find(" ");
            int n = stoi(c.substr(0,i));
            string s = c.substr(i+1);
            for (int i = 0; i < s.size(); i++)
            {
                if(s[i]=='.'){
                    m[s.substr(i+1)]+=n;
                }
            }
            m[s]+=n;
        }
        vector<string>res;
        for (auto &&i : m)
        {
            res.push_back(to_string(i.second)+" "+i.first);
        }
        return res;
    }
};