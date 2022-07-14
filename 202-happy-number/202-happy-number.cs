public class Solution {
    public bool IsHappy(int n) {
        
        var s=n;
        var f=n;
        
        do{
            s=h(s);
            f=h(h(f));
        }while(s!=f);
        
        return s==1;
    }
    public int h(int n){
        var s = 0;
        
        while(n>0){
            var a = n%10;
            s+=a*a;
            n/=10;
        }
        
        return s;
    }
}