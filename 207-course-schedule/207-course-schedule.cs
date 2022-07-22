public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
            var h = new HashSet<int>();
            var q = new Queue<int>();
            var g = new List<List<int>>();
            int[] indegree = new int[numCourses];
            for (int i = 0; i < numCourses; i++)
            {
                g.Add(new List<int>());
            }
            for (int i = 0; i < prerequisites.Length; i++)
            {
                g[prerequisites[i][1]].Add(prerequisites[i][0]);
                indegree[prerequisites[i][0]]++;
            }
            for (int i = 0; i < indegree.Length; i++)
            {
                if (indegree[i] == 0) q.Enqueue(i);
            }
            while (q.Count > 0)
            {
                var a = q.Dequeue();
                if (h.Contains(a))
                {
                    return false;
                }
                h.Add(a);
                foreach (var item in g[a])
                {
                    indegree[item]--;
                    if (indegree[item] == 0)
                    {
                        q.Enqueue(item);
                    }
                }
            }
            return h.Count == numCourses;
    }
}