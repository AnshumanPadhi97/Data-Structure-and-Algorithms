public class Solution {
    public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2) {
            var res= new List<IList<int>>();
            var d = new Dictionary<int, int>();
            foreach (var item in items1)
            {
                if (!d.ContainsKey(item[0]))
                {
                    d.Add(item[0], 0);
                }
                d[item[0]] += item[1];
            }
            foreach (var item in items2)
            {
                if (!d.ContainsKey(item[0]))
                {
                    d.Add(item[0], 0);
                }
                d[item[0]] += item[1];
            }
            for (int i = 0; i < d.Keys.Count; i++)
            {
                res.Add(new List<int>());
            }
            int j = 0;
            var a = d.OrderBy(x => x.Value);
            foreach (var item in a)
            {
                res[j].Add(item.Key);
                res[j].Add(item.Value);
                j++;
            }
            res = res.OrderBy(x => x[0]).ToList();
            return res;
    }
}