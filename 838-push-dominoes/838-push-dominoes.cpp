class Solution {
public:
    string pushDominoes(string dominoes) {
        int l = dominoes.size();
        int left[l];
        int nearestLeftInd = -1;
        for (int i = l-1; i >= 0; i--)
        {
            if(dominoes[i]=='L'){
                nearestLeftInd=i;
            }else if(dominoes[i]=='R'){
                nearestLeftInd=-1;
            }
            left[i]=nearestLeftInd;
        }
        int right[l];
        int nearestRightInd = -1;
        for (int i = 0; i < l; i++)
        {
            if(dominoes[i]=='R'){
                nearestRightInd=i;
            }else if(dominoes[i]=='L'){
                nearestRightInd=-1;
            }
            right[i]=nearestRightInd;
        }
        string res(l,'.');
        for (int i = 0; i < l; i++)
        {
            if(dominoes[i]=='.'){
                int nearestLeft = left[i];
                int nearestRight = right[i];
                int leftDiff = nearestLeft == -1 ? INT_MAX : abs(i-nearestLeft);
                int rightDiff = nearestRight == -1 ? INT_MAX : abs(i-nearestRight);
                if(leftDiff==rightDiff){
                    res[i]='.';
                }
                else if(leftDiff>rightDiff){
                    res[i]='R';
                }else if(leftDiff<rightDiff){
                    res[i]='L';
                }
            }else{
                res[i] = dominoes[i];
            } 
        }
        return res;
    }
};