class Solution {
public:
    static bool comp(vector<int> &a,vector<int> &b){
        if(a[0]==b[0]){
            return a[1]>b[1];
        }
        return a[0]<b[0];
    }
    int numberOfWeakCharacters(vector<vector<int>>& properties) {
        sort(properties.begin(),properties.end(),comp);
        
        int res=0;
        int mini = INT_MIN;

        for (int i = properties.size()-1; i >= 0; i--)
        {
            if(properties[i][1]<mini){
                res++;
            }
            mini=max(mini,properties[i][1]);
        }        
        
        return res;
    }
};