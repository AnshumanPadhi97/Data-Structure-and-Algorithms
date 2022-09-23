class Solution {
public:
    string longestDiverseString(int a, int b, int c) {
        priority_queue<pair<int,char>> q;
        if(a) q.push({a,'a'});
        if(b) q.push({b,'b'});
        if(c) q.push({c,'c'});
        string res="";
        while (!q.empty())
        {
            pair<int,char> p = q.top();
            q.pop();
            int c=p.first;
            char ch=p.second;
            if(res.size()>=2 && res[res.size()-1]==ch && res[res.size()-2]==ch){
                if(q.empty()) break;
                pair<int,char> a = q.top();
                q.pop();
                res+=a.second;
                if(a.first-1>0){
                    q.push({a.first-1,a.second});
                }
            }else{
                c--;
                res+=ch;
            }
            if(c>0){
                q.push({c,ch});
            }
        }        
        return res;
    }
};