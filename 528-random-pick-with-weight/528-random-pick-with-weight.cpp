class Solution {
public:

    vector<int> a;
    Solution(vector<int>& w) {
        for (auto &&i : w)
        {
            if(a.empty()){
                a.push_back(i);
            }else{
                a.push_back(a.back()+i);
            }
        }
    }
    
    int pickIndex() {
        int x = a.back();
        int ind = rand() % x;
        auto it = upper_bound(begin(a),end(a),ind);
        return it-a.begin();
    }
};