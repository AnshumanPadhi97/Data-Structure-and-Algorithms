class Solution {
public:
    vector<int> res;
    void dfs(int num,int n, int k){
        if(n<=0){
            res.push_back(num);
            return;
        }
        for (int i = 0; i < 10; i++)
        {
            if(i==0 && num==0){//skip leading zeros
                continue;
            }
            else if(i!=0 && num==0){//use i as additonal number
                dfs(i,n-1,k);
            }
            else if(abs(num%10 - i)==k){//add i to number
                dfs(num*10+i,n-1,k);
            }
        }

    }
    vector<int> numsSameConsecDiff(int n, int k) {
        if(n==0){
            res.push_back(0);
        }
        dfs(0,n,k);
        return res;
    }
};