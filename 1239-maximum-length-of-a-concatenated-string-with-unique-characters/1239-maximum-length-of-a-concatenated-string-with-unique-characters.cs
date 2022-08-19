public class Solution {
        int res = 0;
        public int MaxLength(IList<string> arr)
        {
            var ls = arr.ToHashSet().ToList();
            dfs(ls, "",0);
            return res;
        }
        public void dfs(List<string> ls,string temp,int st)
        {
            res = Math.Max(res, temp.Length);
            for (int i = st; i < ls.Count; i++)
            {
                var s = $"{temp}{ls[i]}";
                if (!check(s))
                {
                    continue;
                }
                else
                {
                    dfs(ls, s, i + 1);
                }
            }
        }
        public bool check(string a)
        {
            var f = new int[26];
            for (int i = 0; i < a.Length; i++)
            {
                if(f[a[i] - 'a']++ > 0)
                {
                    return false;
                }
            }
            return true;
        }
}