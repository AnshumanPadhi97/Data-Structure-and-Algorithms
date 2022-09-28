class Solution {
public:
    bool check(string s){
        unordered_set<char> p(s.begin(),s.end());
        if(p.size()!=s.size()) return false;
        return true;
    }
    int h(vector<string>& arr,int ind,string s){
        if(!check(s)){
            return 0;
        }
        int res=s.size();
        for (int i = ind; i < arr.size(); i++)
        {
            res=max(res,h(arr,i+1,s+arr[i]));
        }
        return res;
    }
    int maxLength(vector<string>& arr) {
        return h(arr,0,"");
    }
};