class Solution {
public:
    int minCost(string colors, vector<int>& neededTime) {
        priority_queue<int,vector<int>,greater<int>> q;
        int res=0;
        int l = colors.size();
        for (int i = 0; i < l; i++)
        {
            q.push(neededTime[i]);
            int j = i+1;
            for (; j < l; j++)
            {
                if(colors[i]==colors[j]){
                    q.push(neededTime[j]);
                    if(q.size()>1)//out of 2 similar take lowest
                    {
                        res+=q.top();
                        q.pop();
                    }
                }else{
                    break;
                }
            }
            q.pop();
            i=j-1;
        }
        return res;
    }
};