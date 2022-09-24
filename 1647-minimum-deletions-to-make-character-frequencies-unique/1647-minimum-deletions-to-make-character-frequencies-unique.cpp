class Solution {
public:
    int minDeletions(string s) {
        map<char,int>m;
        for(auto i:s){
            m[i]++;
        }
        priority_queue<int> q;
        for(auto i:m){
            q.push(i.second);
        }
        int res=0;
        while(q.size()>1){
            int a = q.top();
            q.pop();
            if(a==q.top()){
                if(a-1>0){
                    q.push(a-1);
                }
                res++;
            }
        }
        return res;
    }
};