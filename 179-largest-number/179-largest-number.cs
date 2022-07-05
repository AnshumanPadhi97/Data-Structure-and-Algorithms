public class Solution {
    public string LargestNumber(int[] nums) {
            var ls = nums.Select(x => x.ToString()).ToList();
            ls.Sort((a, b) => (b + a).CompareTo((a + b)));
            string s = "";
            if (ls.First() == "0") return "0";
            for (int i = 0; i < ls.Count; i++)
            {
                s += ls[i];
            }
            return s;
    }
}