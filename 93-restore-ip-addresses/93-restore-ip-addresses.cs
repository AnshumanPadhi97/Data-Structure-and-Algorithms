public class Solution {
    IList<string> res = new List<string>();
    public IList<string> RestoreIpAddresses(string s)
    {
        h(s, "", 0, 0);
        return res;
    }
    public void h(string s, string temp, int ind, int count)
    {
        if (count > 4) return;
        if (count == 4 && ind == s.Length)
        {
            res.Add(new string(temp));
            return;
        }

        for (int i = 1; i < 4; i++)
        {
            if (ind + i > s.Length) break;

            string a = s.Substring(ind, i);

            if ((a.StartsWith("0") && a.Length > 1) || (i == 3 && int.Parse(a) >= 256)) continue;

            h(s, temp + a + (count == 3 ? "" : "."), ind + i, count + 1);
        }
    }
}