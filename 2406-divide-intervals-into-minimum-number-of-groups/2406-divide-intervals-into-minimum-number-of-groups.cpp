class Solution {
public:
    int minGroups(vector<vector<int>>& intervals) {
        map<int,int> m;
        for (auto &&i : intervals)
        {
            m[i[0]]++;
            m[i[1]+1]--;
        }      
        int sum=0, maxi = 0;
        for (auto &&i : m)
        {
            sum+=i.second;
            maxi=max(maxi,sum);
        }
        return maxi;
    }
};