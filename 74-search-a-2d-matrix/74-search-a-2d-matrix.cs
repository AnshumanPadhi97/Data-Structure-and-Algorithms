public class Solution {
    public bool SearchMatrix(int[][] matrix, int t) {
        var m = matrix.Length;
        var n = matrix[0].Length;
        int lo=0,hi=n-1;
        while(lo<m && hi>=0){
            Console.WriteLine(matrix[lo][hi]);
            if(matrix[lo][hi]==t){
                return true;
            }
            else if(matrix[lo][hi]>t){
                hi--;
            }else{
                lo++;
            }
        }
        return false;
    }
}