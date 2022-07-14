public class Solution {
    HashSet<int> h = new HashSet<int>();
    public bool IsHappy(int n) {
        if(n==1)return true;
        var s=0;
        while(n>0){
            var a = n%10;
            s+=a*a;
            n/=10;
        }
        if(h.Contains(s)){
            return false;
        }
        h.Add(s);
        return IsHappy(s);
    }
}