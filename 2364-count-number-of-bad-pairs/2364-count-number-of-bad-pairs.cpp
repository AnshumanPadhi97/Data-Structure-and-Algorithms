class Solution {
public:
    long long countBadPairs(vector<int>& a) {
        unordered_map<int,int> m;
        long c=0;
        for(int i=0;i<a.size();i++){
            c+=i-m[i-a[i]];
            m[i-a[i]]++;
        }
        return c;
    }
};