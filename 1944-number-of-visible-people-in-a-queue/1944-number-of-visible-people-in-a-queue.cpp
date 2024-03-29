class Solution {
public:
    vector<int> canSeePersonsCount(vector<int>& heights) {
        int n = heights.size();
        vector<int> res(n);
        stack<int> st;
        for (int i = n-1; i >= 0; i--)
        {
            while (!st.empty() && heights[st.top()]<heights[i])
            {
                st.pop();
                res[i]++;
            }
            if(!st.empty()){
                res[i]++;
            }
            st.push(i);
        }        
        return res;
    }
};