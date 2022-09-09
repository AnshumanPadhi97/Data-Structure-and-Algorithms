public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
        var res=new List<string>();
        var root=add(words);
        for(int i=0;i<board.Length;i++){
            for(int j=0;j<board[0].Length;j++){
                dfs(board,i,j,root,res);
            }
        }
        return res;
    }
    public void dfs(char[][] board,int i,int j,trie root,List<string> res){
        char f = board[i][j];
        if(f=='#' || root.c[f-'a']==null)return;
        root=root.c[f-'a'];
        if(root.word!=null){
            res.Add(root.word);
            root.word=null;
        }
        board[i][j]='#';
        if(i>0) dfs(board,i-1,j,root,res);
        if(i<board.Length-1) dfs(board,i+1,j,root,res);
        if(j>0) dfs(board,i,j-1,root,res);
        if(j<board[0].Length-1) dfs(board,i,j+1,root,res);
        board[i][j]=f;
    }
    public trie add(string[] words){
        trie root = new trie();
        foreach(var item in words){
            var p=root;
            foreach(var item2 in item){
                if(p.c[item2-'a']==null){
                    p.c[item2-'a']=new trie();
                }
                p=p.c[item2-'a'];
            }
            p.word=item;
        }
        return root;
    }
    public class trie{
        public trie[] c=new trie[26];
        public string word;
    }
}