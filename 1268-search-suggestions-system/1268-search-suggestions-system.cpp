class Solution {
public:
    vector<vector<string>> suggestedProducts(vector<string>& products, string searchWord) {
        sort(products.begin(),products.end());
        vector<vector<string>> res;
        int forward=0;
        string pref ="";
        int n = products.size();
        for (auto &&c : searchWord)
        {
            pref+=c;
            int a = lower_bound(products.begin()+forward,products.end(),pref)-products.begin();
            res.push_back({});
            for (int i = a; i < min(a+3,n); i++)
            {
                if(!products[i].compare(0,pref.size(),pref)){
                    res.back().push_back(products[i]);
                }
            }
            forward=a;
        }
        return res;
    }
};