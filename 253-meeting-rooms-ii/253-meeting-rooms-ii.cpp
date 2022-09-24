class Solution {
public:
    int minMeetingRooms(vector<vector<int>>& a) {
        map<int,int> m;
        for(auto i:a){
            m[i[0]]++;
            m[i[1]]--;
        }
        for(auto i:m){
            cout<<i.first<<" "<<i.second;
            cout<<"\n";
        }
        int res=0;
        int b=0;
        for(auto i:m){
            b+=i.second;
            res=max(res,b);
        }
        return res;
    }
};