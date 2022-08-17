public class Trie {
    public class node{
        public node[] c;
        public bool end;
        public node(){
            c=new node[26];
            end=false;
        }
    }
    public node root;
    public Trie() {
        root=new node();
    }
    
    public void Insert(string word) {
        var temp = root;
        foreach(var item in word){
            if(temp.c[item-'a']==null){
                temp.c[item-'a']=new node();
            }
            temp=temp.c[item-'a'];
        }
        temp.end=true;
    }
    
    public bool Search(string word) {
        var a = find(word);
        return a==null?false:a.end;
    }
    
    public bool StartsWith(string prefix) {
        var a = find(prefix);
        return a!=null;
    }
    
    public node find(string w){
        var temp = root;
        foreach(var item in w){
            if(temp.c[item-'a']==null){
                return null;
            }else{
                temp=temp.c[item-'a'];
            }
        }
        return temp;
    }
}