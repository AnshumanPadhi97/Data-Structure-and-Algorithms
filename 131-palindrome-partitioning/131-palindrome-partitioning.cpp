class Solution {
public:
bool check(string &s,int i,int j){
        while (i<j)
        {
            if(s[i++]!=s[j--])return false;
        }
        return true;
}

void h(vector<vector<string>> &res,string &s,int start,vector<string> &temp){
    if(start>=s.length()){
        res.push_back(temp);
    }
    for (int i = start; i < s.length(); i++)
    {
        if(check(s,start,i)){
            temp.push_back(s.substr(start,i-start+1));
            h(res,s,i+1,temp);
            temp.pop_back();
        }
    }
}

vector<vector<string>> partition(string s) {
    vector<vector<string>> res;
    vector<string> temp;
    h(res,s,0,temp);
    return res;
}
};