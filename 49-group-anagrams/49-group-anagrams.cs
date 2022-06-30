public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        IList<IList<string>> ls = new List<IList<string>>();
        var d = new Dictionary<string,List<string>>();
        foreach(var item in strs){
            var temp = String.Concat(item.OrderBy(x=>x));
            if(d.ContainsKey(temp)){
                d[temp].Add(item);
            }else{
                d.Add(temp,new List<string>(){item});
            }
        }
        foreach(var item in d){
            ls.Add(item.Value);
        }
        
        return ls;
    }
}