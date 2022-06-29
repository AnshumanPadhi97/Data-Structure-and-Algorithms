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
            var ind = item-'a';
            if(temp.c[ind]==null){
                temp.c[ind]=new node();
            }
            temp = temp.c[ind];
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
    
    public node find(string word){
        var temp = root;
        foreach(var item in word){
            var ind = item-'a';
            if(temp.c[ind]==null)return null;
            temp=temp.c[ind];
        }
        return temp;
    }
}