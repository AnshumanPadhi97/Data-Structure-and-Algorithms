public class Solution {
    List<string> map=new List<string>(){"abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"};
    List<string> res = new List<string>();
    public IList<string> LetterCombinations(string d) {
        if(d=="")return res;
        h(d,0,"");
        return res;
    }
    public void h(string d,int start,string temp){
        if(temp.Length==d.Length){
            res.Add(new string(temp));
            return;
        }
        foreach(var item in map[d[start]-'2']){
            temp+=item;
            h(d,start+1,temp);
            temp=temp.Substring(0,temp.Length-1);
        }
    }
}