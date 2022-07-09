public class Solution {
        public string CountAndSay(int a)
        {
            if (a <= 0) return "-1";
            string res = "1";
            for (int i = 1; i < a; i++)
            {
                res = build(res);
            }
            return res;
        }
        public string build(string res)
        {
            StringBuilder sb = new StringBuilder();
            int p = 0;
            while (p<res.Length)
            {
                var val = res[p];
                int c = 0;
                while (p<res.Length && res[p]==val)
                {
                    c++;
                    p++;
                }
                sb.Append(c);
                sb.Append(val);
            }
            return sb.ToString();
        }
}