class Solution {
public:
    int minCost(string colors, vector<int>& neededTime) {
        int res=0;
        stack<pair<char,int>> st;
        int l = colors.size();
        for (int i = 0; i < l; i++)
        {
            if(st.empty() || st.top().first != colors[i]){
                st.push({colors[i],neededTime[i]});
            }else{
                res+=min(st.top().second,neededTime[i]);
                if(st.top().second<neededTime[i]){
                    st.pop();
                    st.push({colors[i],neededTime[i]});
                }
            }
        }
        return res;
    }
};