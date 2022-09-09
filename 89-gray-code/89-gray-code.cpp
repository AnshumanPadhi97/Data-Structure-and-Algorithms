class Solution {
public:
    vector<int> grayCode(int n) {
        vector<int> res;
        /*
		0 1 2 3 4 5 6 7 -- in range(0,2^n-1) 
		0 0 1 1 2 2 3 3  - for getting these values i >> 1
		-------------------------------------------------- xor
		0 1 3 2 6 7 5 4 - required answer order
		*/
        for(int i=0;i<(1<<n);i++){
            res.push_back(i ^ (i>>1));
        }
        return res;
    }
};