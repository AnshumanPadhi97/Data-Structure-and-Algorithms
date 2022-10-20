public class Solution {
    public string DecodeString(string s) {
        var a = new Stack<string>();
        var b = new Stack<int>();
        string res="";
        int c=0;
        foreach(var item in s){
            if(char.IsDigit(item)){
                c=c*10+(item-'0');
            }
            else if(char.IsLetter(item)){
                res+=item;
            }
            else if(item=='['){
                b.Push(c);
                a.Push(res);
                res="";
                c=0;
            }
            else if(item==']'){
                var t = a.Pop();
                int l = b.Pop();
                while(l-->0){
                    t+=res;
                }
                res=t;
            }
        }
        return res;
    }
}