class Solution {
public:
    int nextGreaterElement(int n) {
        string a = to_string(n);
        if(!nextpermutation(a)) return -1;
        auto res = stoll(a);
        return (res>INT_MAX || res<=n)?-1:res;
    }
    bool nextpermutation(string& s){
        if(s.empty()) return false;
        int i=s.size()-1;
        while (i>=1 && s[i]<=s[i-1]) // pivot greater than prev
        {
            i--;
        }
        if(i==0)return false;
        int j=s.size()-1;
        while (s[j]<=s[i-1])// just greater than pivot
        {
            j--;
        }
        swap(s[i-1],s[j]);//swap
        reverse(s.begin()+i,s.end());//reverse back side
        return true;
    }
};