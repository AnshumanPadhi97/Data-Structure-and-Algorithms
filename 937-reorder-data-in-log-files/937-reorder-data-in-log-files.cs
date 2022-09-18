public class Solution {
    public string[] ReorderLogFiles(string[] logs) {
        var a = new List<string>();
        var b = new List<string>();
        foreach(var item in logs){
            if(char.IsDigit(item.Split(' ')[1][0])){
                b.Add(item);
            }else{
                a.Add(item);
            }
        }
        a.Sort((a,b)=>{
            var l1 = a.Split(' ',2);
            var l2 = b.Split(' ',2);
            var c = l1[1].CompareTo(l2[1]);
            if(c!=0)return c;
            return l1[0].CompareTo(l2[0]);
        });
        a.AddRange(b);
        return a.ToArray();
    }
}