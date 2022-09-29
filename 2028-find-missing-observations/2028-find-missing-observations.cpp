class Solution {
public:
    vector<int> missingRolls(vector<int>& rolls, int mean, int n) {
        
        int curr = accumulate(rolls.begin(),rolls.end(),0), m = rolls.size();
        int missing = mean * (n+m) - curr;
        if(missing<n || missing>6*n) return {};

        int part = missing/n, rem = missing%n;
        vector<int> res(n,part);
        for (int i = 0; i < rem; ++i)
        {
            ++res[i];
        }
        return res;
    }
};