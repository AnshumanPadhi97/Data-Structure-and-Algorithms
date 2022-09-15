class Solution {
public:
    vector<int> findOriginalArray(vector<int>& changed) {
        map<int,int> m;
        vector<int> res;
        
        if(changed.size()%2) return res;

        sort(changed.begin(),changed.end());
        
        for (auto &&i : changed)
        {
            m[i]++;
        }
        for (auto &&i : changed)
        {
            if(m[i]){
                m[i]--;
                res.push_back(i);
                if(m[2*i]){
                    m[2*i]--;
                }else{
                    return {};
                }
            }
        }
        return res;
    }
};