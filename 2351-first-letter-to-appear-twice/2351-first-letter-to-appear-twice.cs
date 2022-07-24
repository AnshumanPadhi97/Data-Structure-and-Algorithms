public class Solution {
    public char RepeatedCharacter(string s) {
            var res = s[0];
            var h = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (h.Contains(s[i]))
                {
                    res = s[i];
                    break;
                }
                h.Add(s[i]);
            }
            return res;
    }
}