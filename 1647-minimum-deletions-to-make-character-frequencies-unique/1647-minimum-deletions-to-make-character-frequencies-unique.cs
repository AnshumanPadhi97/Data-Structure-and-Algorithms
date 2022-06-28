public class Solution {
    public int MinDeletions(string s) {
        int[] a = new int[26];
        foreach (var item in s)
        {
            a[item - 'a']++;
        }
        int res = 0;
        var h = new HashSet<int>();
        for (int i = 0; i < 26; i++)
        {
            while(a[i] > 0 && h.Contains(a[i]))
            {
                a[i]--;res++;
            }
            h.Add(a[i]);
        }
        return res;
    }
}