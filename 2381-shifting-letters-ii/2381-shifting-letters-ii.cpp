class Solution {
public:
    string shiftingLetters(string s, vector<vector<int>>& sh) {
        long size = s.size();
        vector<long> line(size+1,0);
        for (auto &&i : sh)
        {
            if(i[2]){
                line[i[0]]++;
                line[i[1]+1]--;
            }else{
                line[i[0]]--;
                line[i[1]+1]++;
            }
        }
        for (int i = 1; i <= size; i++)
        {
            line[i]+=line[i-1];
        }
        for (int i = 0; i < size; i++)
        {
            int a = (s[i]-'a'+line[i])%26;
            a=(a+26)%26;
            s[i]='a'+a;
        }
        return s;
    }
};