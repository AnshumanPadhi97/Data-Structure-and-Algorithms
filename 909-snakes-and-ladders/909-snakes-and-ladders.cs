public class Solution {
    public int SnakesAndLadders(int[][] board) {
            int n = board.Length;
            var q = new Queue<int>();
            q.Enqueue(1);
            if (board[0][0] != -1) return -1;

            var vis = new HashSet<int>();
            vis.Add(1);

            int res = 0;

            while (q.Count>0)
            {
                var l = q.Count;
                while (l-- > 0)
                {
                    var a = q.Dequeue();
                    if (a == n * n)
                    {
                        return res;
                    }

                    for (int j = 1; j <= 6; j++)
                    {
                        var next = a + j;
                        if (next > n * n) 
                            break;

                        var ind = next - 1;
                        var r = ind / n;
                        var c = ind % n;

                        if (r % 2 == 1)
                        {
                            c = (n - 1) - c;
                        }

                        r = (n - 1) - r;

                        if (board[r][c] != -1)
                        {
                            next = board[r][c];
                        }

                        if (vis.Add(next))
                        {
                            q.Enqueue(next);
                        }
                    }
                }
                res++;
            }

            return -1;
    }
}