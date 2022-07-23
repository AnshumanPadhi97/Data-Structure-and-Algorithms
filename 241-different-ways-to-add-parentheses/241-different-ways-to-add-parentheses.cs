public class Solution {
    public IList<int> DiffWaysToCompute(string expression) {
            var res= new List<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                if (!char.IsDigit(expression[i]))
                {
                    var res1 = DiffWaysToCompute(expression.Substring(0, i));
                    var res2 = DiffWaysToCompute(expression.Substring(i+1));
                    foreach (var a in res1)
                    {
                        foreach (var b in res2)
                        {
                            int c = 0;
                            switch (expression[i])
                            {
                                case '+':c = a + b;break;
                                case '-':c = a - b;break;
                                case '*':c = a * b;break;
                            }
                            res.Add(c);
                        }
                    }
                }
            }
            if (res.Count == 0) res.Add(int.Parse(expression));
            return res;
    }
}