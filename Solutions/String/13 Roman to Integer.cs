//roman to int
public class Solution13
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        map.Add('I', 1);
        map.Add('V', 5);
        map.Add('X', 10);
        map.Add('L', 50);
        map.Add('C', 100);
        map.Add('D', 500);
        map.Add('M', 1000);

        int res = map[s[s.Length - 1]];

        for (int i = s.Length - 2; i >= 0; i--)
        {
            if (map[s[i]] < map[s[i + 1]])
            {
                res -= map[s[i]];
            }
            else
            {
                res += map[s[i]];
            }
        }

        return res;
    }
}