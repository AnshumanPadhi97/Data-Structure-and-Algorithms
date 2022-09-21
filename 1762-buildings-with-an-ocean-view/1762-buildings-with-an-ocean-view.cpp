class Solution {
public:
    vector<int> findBuildings(vector<int>& heights) {
        vector<int> res;
        int n = heights.size();
        stack<int> st;
        for (int i = n-1; i >=0; i--)
        {
            while (!st.empty() && heights[st.top()]<heights[i])
            {
                st.pop();
            }
            if(st.empty()){
                res.push_back(i);
            }
            st.push(i);
        }        
        reverse(res.begin(),res.end());
        return res;
    }
};