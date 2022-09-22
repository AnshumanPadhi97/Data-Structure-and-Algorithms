public class Solution {
    public string ReverseWords(string s) {
        var a = s.Split(' ');
        var res = "";
        for(int i=0;i<a.Length;i++){
            var item = a[i];
            var b = new string(item.Reverse().ToArray());
            if(i==a.Length-1){
                res+=b;
            }else{
                res=res+b+" ";   
            }
        }
        return res;
    }
}