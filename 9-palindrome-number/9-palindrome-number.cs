public class Solution9 {
    public bool IsPalindrome(int x) {
        if(x<0)return false;
        int temp = x;
        int op = 0;
        while(temp>0){
            var t = temp%10;
            temp/=10;
            op = op*10+t;
        }
        return op==x;
    }
}