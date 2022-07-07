public class Solution {
        IList<string> res = new List<string>();
        public IList<string> GenerateParenthesis(int n)
        {
            h(n, 0, 0,"");
            return res;
        }
        public void h(int n,int o,int c,string temp)
        {
            if(temp.Length == n * 2)
            {
                res.Add(new string(temp));
                return;
            }
            if (o < n)
            {
                h(n, o + 1, c, temp + '(');
            }
            if (c<o)
            {
                h(n, o, c + 1, temp + ')');
            }
        }
}