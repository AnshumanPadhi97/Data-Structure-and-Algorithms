//Return the city with the smallest number of cities that are reachable through some path and whose distance is at most distanceThreshold,
//If there are multiple such cities, return the city with the greatest number.

public class Solution1134
{
    public int FindTheCity(int n, int[][] edges, int t)
    {
        int[][] dist = new int[n][];
        for (int i = 0; i < n; i++)
        {
            dist[i] = new int[n];
            Array.Fill(dist[i], 100000000);//not int.MaxValue because it overflows
        }
        for (int i = 0; i < n; i++)
        {
            dist[i][i] = 0;
        }
        foreach (var item in edges)
        {
            dist[item[0]][item[1]] = item[2];
            dist[item[1]][item[0]] = item[2];
        }

        //floyd warshall, all source all destination shortest distance
        for (int k = 0; k < n; k++)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dist[i][j] = Math.Min(dist[i][j], dist[i][k] + dist[k][j]);
                }
            }
        }
        
        int res = 0, smallest = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            int c = 0;
            for (int j = 0; j < n; j++)
            {
                if (dist[i][j] <= t)
                {
                    c++;
                }
            }
            if (c <= smallest)
            {
                res = i;
                smallest = c;
            }
        }
        return res;
    }
}