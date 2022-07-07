public class Solution {
        public bool IsInterleave(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length)
            {
                return false;
            }

            return DFS(s1, 0, s2, 0, s3, 0, new Dictionary<(int, int), bool>());
        }
        private bool DFS(string s1, int i, string s2, int j, string s3, int k, IDictionary<(int, int), bool> memo)
        {
            if (memo.ContainsKey((i, j)))
            {
                return memo[(i, j)];
            }

            if (i == s1.Length)
            {
                memo[(i, j)] = s2.Substring(j).Equals(s3.Substring(k));
                return memo[(i, j)];
            }

            if (j == s2.Length)
            {
                memo[(i, j)] = s1.Substring(i).Equals(s3.Substring(k));
                return memo[(i, j)];
            }

            bool ans = false;
            if (s3[k] == s1[i] && DFS(s1, i + 1, s2, j, s3, k + 1, memo) || s3[k] == s2[j] && DFS(s1, i, s2, j + 1, s3, k + 1, memo))
            {
                ans = true;
            }
            memo[(i, j)] = ans;

            return ans;
        }
}