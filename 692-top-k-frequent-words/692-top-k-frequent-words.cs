public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
            var d = new Dictionary<string, int>();
            foreach (var item in words)
            {
                if (!d.ContainsKey(item))
                {
                    d.Add(item, 0);
                }
                d[item]++;
            }
            return d.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(k).Select(x => x.Key).ToList();
    }
}