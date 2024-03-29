class TicTacToe {
public:

    vector<int> rowJudge;
    vector<int> colJudge;
    int diag, anti;
    int total;
    
    TicTacToe(int n):total(n), rowJudge(n), colJudge(n),diag(0),anti(0){}

    int move(int row, int col, int player) {
        
        int add = player == 1 ? 1 : -1;
        
        diag += row == col ? add : 0;
        anti += row == total - col - 1 ? add : 0;
        
        rowJudge[row] += add;
        colJudge[col] += add;
        
        if(abs(rowJudge[row]) == total || abs(colJudge[col]) == total || abs(diag) == total || abs(anti) == total) {
            return player;
        }
        
        return 0;
    }
};