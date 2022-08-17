public class Solution {
    public void Rotate(int[][] m) {
        int n = m.Length;
        for(int i=0;i<n;i++){
            for(int j=i+1;j<n;j++){
                var temp = m[j][i];
                m[j][i]=m[i][j];
                m[i][j]=temp;
            }
        }
        for(int i=0;i<n;i++){
            for(int j=0;j<n/2;j++){
                var temp = m[i][j];
                m[i][j]=m[i][n-j-1];
                m[i][n-j-1]=temp;
            }
        }
    }
}