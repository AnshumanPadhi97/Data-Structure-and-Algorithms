class Solution {
public:
    int day;
    vector<vector<vector<int>>> dp;
    
    long long solve(vector<int> &job, int count, int diff, int i)
    {
        if(count == day && i == job.size()) return 0;
        
        if(i == job.size() || count >= day) return INT_MAX;
        
        if( diff != -1 && dp[i][diff][count] != -1) return dp[i][diff][count];
        
        if(diff == -1) diff = i;
        
        else if(job[i]>job[diff]) diff = i;
        
        long long left = solve(job, count+1, -1, i+1);
        long long right = solve(job, count, diff, i+1);
        
        if(left != INT_MAX) left += job[diff];
        
        return dp[i][diff][count] = min(left, right);
    }
    
    int minDifficulty(vector<int>& job, int d) {
        day = d;
        dp = vector<vector<vector<int>>> (301, vector<vector<int>> (301, vector<int> (11, -1)));
        
        long long res = solve(job, 0, -1, 0);
        
        if(res >= INT_MAX) return -1; 
        return (int)(res);
    }
};