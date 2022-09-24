class Solution {
public:
    int maximumPopulation(vector<vector<int>>& logs) {
        int a[2051]={}, res=0;
        for(auto i:logs){
            a[i[0]]++;
            a[i[1]]--;
        }
        for(auto i=1950;i<2050;i++){
            a[i]+=a[i-1];
            res=a[i]>a[res]?i:res;
        }
        return res;
    }
};