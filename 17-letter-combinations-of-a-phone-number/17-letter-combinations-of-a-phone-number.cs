public class Solution {
    
    List<string> res = new List<string>();
    List<string> map = new List<string>(){"abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"};
    
    public IList<string> LetterCombinations(string digits) {
        if(digits.Length==0)return res;
        h(digits,"",0);
        return res;
    }
    
    public void h(string digits,string temp,int i){
        if(i==digits.Length){
            res.Add(new string(temp));
            return;
        }
        foreach(var item in map[digits[i]-'2']){
            temp+=item;
            h(digits,temp,i+1);
            temp=temp.Substring(0,temp.Length-1);
        }
    }
}