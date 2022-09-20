public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        
        var res=1;
        var q = new Queue<string>();
        var h = wordList.ToHashSet<string>();
        var vis = new HashSet<string>();
        
        q.Enqueue(beginWord);
        
        while(q.Count>0){
            var l = q.Count;
            while(l-->0){
                var a = q.Dequeue();   
                if(a==endWord)return res;
                
                for(int j=0;j<a.Length;j++)
                {
                    for(char k='a';k<='z';k++)
                    {
                        var b=a.ToCharArray();
                        b[j]=k;
                        
                        var s = new string(b);
                        if(h.Contains(s) && !vis.Contains(s)){
                            q.Enqueue(s);
                            vis.Add(s);
                        }
                    }
                }
            }
            res++;
        }
        
        return 0;
    }
}