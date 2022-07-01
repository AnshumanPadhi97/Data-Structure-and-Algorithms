public class Solution {
    public int Reverse(int x) {
        var a = x.ToString().ToCharArray().ToList();
        bool neg=false;
        if(x<0){
            neg=true;
            a.RemoveAt(0);
        }
        a.Reverse();
        var c = a.ToArray<char>();
        var q = "";
        if(neg){
            q+="-";
        }
        var p = new string(c);
        q+=p;
        try{
            return int.Parse(q);
        }catch{
            return 0;
        }
    }
}