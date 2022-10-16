class Solution {
public:
    int maxProfit(int k, vector<int>& prices) {
        int n = prices.size();

        vector<int> after(2*k+1,0);
        vector<int> curr(2*k+1,0);
        
        //0 1 2 3 4 5
        //buy sell buy sell buy sell
        
        for (int i = n-1; i >= 0; i--)
        {
            for (int transactionNo = 2*k-1; transactionNo >= 0; transactionNo--)
            {
                if(transactionNo%2==0){//buy
                    curr[transactionNo] = max(-prices[i]+after[transactionNo+1],after[transactionNo]);
                }else{
                    curr[transactionNo] = max(prices[i]+after[transactionNo+1],after[transactionNo]);
                }
            }
            after=curr;
        }
        
        return after[0];
    }
};