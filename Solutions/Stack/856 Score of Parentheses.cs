/*
 * The score of a balanced parentheses string is based on the following rule:

    "()" has score 1.
    AB has score A + B, where A and B are balanced parentheses strings.
    (A) has score 2 * A, where A is a balanced parentheses string.
 */
public class Solution856
{
    public int ScoreOfParentheses1(string s)
    {
        var st = new Stack<int>();
        st.Push(0);

        foreach (var item in s)
        {
            if (item == '(')
            {
                st.Push(0);
            }
            else
            {
                var a = st.Pop();
                var b = st.Pop();
                st.Push(b + Math.Max(2 * a, 1));
            }
        }
        return st.Pop();
    }
    public int ScoreOfParentheses2(string s)
    {
        int res = 0, bal = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                bal++;
            }
            else
            {
                bal--;
                if (s[i - 1] == '(')
                {
                    res += 1 << bal;
                }
            }
        }
        return res;
    }
}