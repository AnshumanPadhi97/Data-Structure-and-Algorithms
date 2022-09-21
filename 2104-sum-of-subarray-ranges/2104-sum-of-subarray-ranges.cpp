class Solution {
public:
    long long subArrayRanges(vector<int>& nums) {
        
        int n = nums.size();
        vector<int> minPrev(n,-1), minNext(n,n), maxPrev(n,-1), maxNext(n,n);
        
        stack<int> st;
        //for min prev
        for (int i = 0; i < n; i++)
        {
            while (!st.empty() && nums[st.top()]>=nums[i])
            {
                st.pop();
            }
            if(!st.empty())
            {
                minPrev[i] = st.top();
            }
            st.push(i);
        }

        while (!st.empty()){st.pop();}    

        //for min next
        for (int i = n-1; i >= 0; i--)
        {
            while (!st.empty() && nums[st.top()]>nums[i])
            {
                st.pop();
            }
            if(!st.empty())
            {
                minNext[i] = st.top();
            }
            st.push(i);
        }

        while (!st.empty()){st.pop();}

        //for max prev
        for (int i = 0; i < n; i++)
        {
            while (!st.empty() && nums[st.top()]<=nums[i])
            {
                st.pop();
            }
            if(!st.empty())
            {
                maxPrev[i] = st.top();
            }
            st.push(i);        
        }
        
        while (!st.empty()){st.pop();}
        
        //for max next
        for (int i = n-1; i >= 0; i--)
        {
            while (!st.empty() && nums[st.top()]<nums[i])
            {
                st.pop();
            }
            if(!st.empty())
            {
                maxNext[i] = st.top();
            }
            st.push(i);
        }
        
        long long sum=0;
        for (int i = 0; i < n; i++)
        {
            long long leftMin = i - minPrev[i], rightMin = minNext[i] - i;
            long long leftMax = i - maxPrev[i], rightMax = maxNext[i] - i;
            sum+= (leftMax * rightMax - leftMin * rightMin)* nums[i];
        }
        return sum;
    }
};