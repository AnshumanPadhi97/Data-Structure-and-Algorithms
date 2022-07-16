public class Solution {
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4) {
            var d = new Dictionary<int, int>();
            int res = 0;
            foreach (var item in nums1)
            {
                foreach (var item2 in nums2)
                {
                    var s = (item + item2);
                    if (!d.ContainsKey(s))
                    {
                        d.Add(s, 1);
                    }
                    else
                    {
                        d[s]++;
                    }
                }
            }
            foreach (var item in nums3)
            {
                foreach (var item2 in nums4)
                {
                    var s = -(item + item2);
                    if (d.ContainsKey(s))
                    {
                        res += d[s];
                    }
                }
            }
            return res;
    }
}