class Solution {
public:
    bool reorderedPowerOf2(int n) {
        vector<int> b = h(n);
        for(int i=0, c=1; i<30; i++, c<<=1){
            if(b==h(c))return true;
        }
        return false;
    }
    vector<int> h(int n){
        vector<int> a(10);
        while(n){
            a[n%10]++;
            n/=10;
        }
        return a;
    }
};