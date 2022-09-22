/**
 * // This is the BinaryMatrix's API interface.
 * // You should not implement it, or speculate about its implementation
 * class BinaryMatrix {
 *   public:
 *     int get(int row, int col);
 *     vector<int> dimensions();
 * };
 */

class Solution {
public:
    int leftMostColumnWithOne(BinaryMatrix &binaryMatrix) {
        auto a = binaryMatrix.dimensions();
        int m=a[0];
        int n=a[1];
        int x=0,y=n-1;
        while(x<m && y>=0){
            if(binaryMatrix.get(x,y)){
                y-=1;
            }else{
                x+=1;
            }
        }
        return y == n-1?-1:y+1;
    }
};