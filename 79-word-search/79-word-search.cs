public class Solution {
    public bool Exist(char[][] b, string word) {
        int m = b.Length;
        int n = b[0].Length;
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(dfs(b,word, i, j, 0)){
                    return true;
                }
            }
        }
        return false;
    }
    public bool dfs(char[][] b, string word, int i,int j, int k){
        if(k==word.Length)return true;
        
        if(i<0||j<0||i>=b.Length||j>=b[0].Length||b[i][j]=='0'){
            return false;
        }
        
        if(b[i][j]!=word[k])return false;
        
        var a = b[i][j];
        
        b[i][j]='0';
        
        bool c = dfs(b,word,i+1,j,k+1)||
                 dfs(b,word,i-1,j,k+1)||
                 dfs(b,word,i,j+1,k+1)||
                 dfs(b,word,i,j-1,k+1);
        
        b[i][j]=a;
        
        return c;
    }
}