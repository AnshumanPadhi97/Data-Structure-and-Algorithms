public class Solution {
    public string BestHand(int[] ranks, char[] suits) {
            var d1 = new Dictionary<int, int>();
            foreach (var item in ranks)
            {
                if (!d1.ContainsKey(item))
                {
                    d1.Add(item, 0);
                }
                d1[item]++;
            }
            if (ranks.All(x => x == suits[0]))
            {
                return "Flush";
            }
            if (suits.All(x => x == suits[0]))
            {
                return "Flush";
            }
            if (d1.Values.Max() >= 3 && d1.Values.Max() < 5)
            {
                return "Three of a Kind";
            }
            if (d1.Values.Max() == 2)
            {
                return "Pair";
            }
            else
            {
                return "High Card";
            }
    }
}