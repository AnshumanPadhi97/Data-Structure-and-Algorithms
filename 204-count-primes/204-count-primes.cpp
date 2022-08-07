class Solution {
public:
    int countPrimes(int n) {
        if(n==0 || n==1)return 0;
        vector<bool> a(n,true);
        for(int i=2;i*i<n;i++){
            if(a[i]){
                for(int j=i*i;j<n;j+=i){
                    a[j]=false;
                }
            }
        }
        int res=0;
        for(int i=2;i<n;i++){
            if(a[i]){
                res++;
            }
        }
        return res;
    }
};