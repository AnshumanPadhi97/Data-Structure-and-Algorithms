class Solution {
public:
    vector<int> findDiagonalOrder(vector<vector<int>>& mat) {
        int m = mat.size();
        int n = mat[0].size();

        if(m==0) return {};        
        if(n==0) return {};

        vector<int> res(m*n);
        
        int row=0;
        int col=0;
        for (int i = 0; i < m*n; i++)
        {
            res[i]=mat[row][col];
            
            if((col+row)%2==0){
                //upward
                if(col==n-1){
                    row++;
                }
                else if(row==0){
                    col++;
                }
                else{
                    row--;
                    col++;
                }
            }else{
                //downward
                if(row==m-1){
                    col++;
                }
                else if(col==0){
                    row++;
                }
                else{
                    row++;
                    col--;
                }
            }
        }        

        return res;
    }
};