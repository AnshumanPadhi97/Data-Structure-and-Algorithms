class Solution {
public:
    vector<int> findClosestElements(vector<int>& arr, int k, int x) {
        
        priority_queue<pair<int, int>, vector<pair<int, int>>, greater<pair<int, int>>> q;
        
        for (int i = 0; i < arr.size(); i++)
        {
            q.push({abs(arr[i]-x),arr[i]});
        }
        
        vector<int> res;
        for (int i = 0; i < k; i++)
        {
            res.push_back(q.top().second);
            q.pop();
        }
        
        sort(res.begin(),res.end());
        return res;
    }
};