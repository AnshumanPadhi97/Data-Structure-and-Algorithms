class Solution {
public:
    vector<int> platesBetweenCandles(string s, vector<vector<int>>& queries) {
        vector<int> a, res;
        for (int i = 0; i < s.size(); i++)
        {
            if(s[i]=='|'){
                a.push_back(i);
            }
        }
        cout<<endl;
        for (int q = 0; q < queries.size(); q++)
        {
            int i = lower_bound(a.begin(),a.end(),queries[q][0])-a.begin();
            int j = upper_bound(a.begin(),a.end(),queries[q][1])-a.begin()-1;
            if(i<j){
                int inBetweencandles = j-i;
                int plates = a[j]-a[i];
                res.push_back(plates-inBetweencandles);
            }else{
                res.push_back(0);
            }
        }
        return res;
    }
};