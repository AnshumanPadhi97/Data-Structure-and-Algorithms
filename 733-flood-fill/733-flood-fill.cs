public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if(image[sr][sc]==color)return image;
        var oc = image[sr][sc];
        h(image,sr,sc,color,oc);
        return image;
    }
    public void h(int[][] a,int i,int j,int c,int oc){
        if(i<0||j<0||i>=a.Length||j>=a[0].Length||a[i][j]!=oc){
            return;
        }
        a[i][j]=c;
        h(a,i+1,j,c,oc);
        h(a,i-1,j,c,oc);
        h(a,i,j+1,c,oc);
        h(a,i,j-1,c,oc);
    }
}