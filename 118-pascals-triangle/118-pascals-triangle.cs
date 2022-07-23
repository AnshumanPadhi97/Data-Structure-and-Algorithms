public class Solution {
    public IList<IList<int>> Generate(int n) {
        IList<IList<int>> res = new List<IList<int>>();
            res.Add(new List<int>() { 1 });
            if (n == 1) return res;
            res.Add(new List<int>() { 1,1 });
            if (n == 2) return res;

            for (int i = 2; i < n; i++)
            {
                var ls = new List<int>();
                ls.Add(1);
                for (int j = 0; j < res[i-1].Count-1; j++)
                {
                    ls.Add(res[i - 1][j] + res[i - 1][j+1]);
                }
                ls.Add(1);
                res.Add(ls.ToList());
            }
            return res;
    }
}