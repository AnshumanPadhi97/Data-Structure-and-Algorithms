public class Solution {
    public bool IsToeplitzMatrix(int[][] m) {
        for(int i=0;i<m.Length;i++){
            for(int j=0;j<m[0].Length;j++){
                if(i>0 && j>0 && m[i][j]!=m[i-1][j-1]){
                    return false;
                }
            }
        }
        return true;
    }
}