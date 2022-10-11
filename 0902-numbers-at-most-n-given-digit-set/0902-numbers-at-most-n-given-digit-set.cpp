class Solution {
public:
    int atMostNGivenDigitSet(vector<string>& digits, int n) {
        string a = to_string(n);
        int l = a.size(), dsize = digits.size();
        int res=0;
        
        for(int i=1;i<l;i++){//no of numbers from 1 to n-1 len which are small than n
            res+=pow(dsize,i);
        }
        
        for(int i=0;i<l;i++){
            bool hasSameNum = false;
            for(auto s:digits){
                if(s[0]<a[i]){
                    res+=pow(dsize,l-i-1);
                }
                else if(s[0]==a[i]){
                    hasSameNum=true;
                    if(i==l-1){
                        res++;
                    }
                }
            }
            if(!hasSameNum) return res;
        }
        return res;
    }
};