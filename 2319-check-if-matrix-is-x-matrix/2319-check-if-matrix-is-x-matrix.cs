public class Solution {
    public bool CheckXMatrix(int[][] grid) {
        

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (i == j ||  i == grid.Length -j-1)
                    {
                        Console.WriteLine(i + " " + j);
                        if (grid[i][j] == 0)
                        {
                            return false;
                        }
                    }
                    else if (grid[i][j] != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
    }
}