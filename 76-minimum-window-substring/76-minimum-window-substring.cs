public class Solution {
    public string MinWindow(string s, string t) {
        var l1 = s.Length;
        var l2 = t.Length;
        if(l2>l1)return "";
        
        var d = new Dictionary<char,int>();
        foreach(var item in t){
            if(!d.ContainsKey(item))
                d.Add(item,0);
            d[item]++;
        }
        
        int l=d.Count;
        
        int i=0,j=0,head=0,len=int.MaxValue;
        while(j<l1){
            if(d.ContainsKey(s[j])){
                d[s[j]]--;
                if(d[s[j]]==0){
                    l--;
                }
            }
            j++;
            while(l==0){
                var c=s[i];
                if(d.ContainsKey(c)){
                    d[c]++;
                    if(d[c]>0){
                        l++;   
                    }
                }
                if(j-i<len){
                    len=j-i;
                    head=i;
                }
                i++;
            }
        }
        return len==int.MaxValue ? "":s.Substring(head,len);
    }
}