public class Solution {
    public string FrequencySort(string s) {
        var d = new Dictionary<char,int>();
        foreach(var item in s){
            if(!d.ContainsKey(item)){
                d.Add(item,0);
            }
            d[item]++;
        }
        var a = d.OrderByDescending(x=>x.Value);
        var p = new StringBuilder();
        foreach(var item in a){
            p.Append(item.Key,item.Value);
        }
        return p.ToString();
    }
}