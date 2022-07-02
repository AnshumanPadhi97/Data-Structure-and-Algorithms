public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for(int i=0;i<9;i++){
            for(int j=0;j<9;j++){
                if(board[i][j]!='.'){
                    if(!check(i,j,board,board[i][j])){
                        return false;
                    }
                }
            }
        }
        return true;
    }
    public bool check(int a,int b,char[][] board, char c){
        for(int j=0;j<9;j++){
            if(j==b)continue;
            if(board[a][j]==c){
                return false;
            }
        }
        for(int i=0;i<9;i++){
            if(i==a)continue;
            if(board[i][b]==c){
                return false;
            }
        }
        int r = a - a%3;
        int d = b - b%3;
        for(int i=0;i<3;i++){
            for(int j=0;j<3;j++){
                if(board[r+i][d+j]==c && (r+i!=a && d+j!=b)){
                    return false;
                }
            }
        }
        return true;
    }
}