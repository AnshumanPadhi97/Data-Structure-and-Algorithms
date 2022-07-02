public class Solution {
        int n;
        string[] words;
        int max = 0;
        public int MaxLength(IList<string> arr)
        {
            words = new HashSet<string>(arr).ToArray();
            n = words.Length;
            dfs(0, "");
            return max;
        }

        void dfs(int start, string curr)
        {
            max = Math.Max(curr.Length, max);

            for (int end = start; end < n; end++)
            {
                var sub = $"{curr}{words[end]}";
                if (!IsUnique(sub)) continue;
                dfs(end + 1, sub);
            }
        }

        bool IsUnique(string s)
        {
            char[] ca = new char[26];
            foreach (char ch in s)
            {
                if (ca[ch - 'a']++ > 0)
                    return false;
            }
            return true;
        }
}