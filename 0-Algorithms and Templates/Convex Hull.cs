using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6.Algorithms
{
    internal class conver_hull_jarvis_marsh
    {
        public int orientation(int[] p, int[] q, int[] r)
        {
            return (q[1] - p[1]) * (r[0] - q[0]) - (q[0] - p[0]) * (r[1] - q[1]);
        }
        public bool inBetween(int[] p, int[] i, int[] q)
        {
            var a = i[0] >= p[0] && i[0] <= q[0] || i[0] <= p[0] && i[0] >= q[0];
            var b = i[1] >= p[1] && i[1] <= q[1] || i[1] <= p[1] && i[1] >= q[1];
            return a && b;
        }

        public int[][] converhull(int[][] trees)
        {
            HashSet<int[]> hull = new HashSet<int[]>();
            if (trees.Length < 4)
            {
                foreach (var item in trees)
                {
                    hull.Add(item);
                }
                return hull.ToArray();
            }

            int left = 0;
            for (int i = 0; i < trees.Length; i++)
            {
                if (trees[i][0] < trees[left][0])
                {
                    left = i;
                }
            }

            int p = left;

            do
            {
                var q = (p + 1) % trees.Length;

                for (int i = 0; i < trees.Length; i++)
                {
                    if (orientation(trees[p], trees[i], trees[q]) < 0)
                    {
                        q = i;
                    }
                }

                for (int i = 0; i < trees.Length; i++)
                {
                    if (i != p && i != q && orientation(trees[p], trees[i], trees[q]) == 0 && inBetween(trees[p], trees[i], trees[q]))
                    {
                        hull.Add(trees[i]);
                    }
                }

                hull.Add(trees[q]);
                p = q;

            } while (p != left);

            return hull.ToArray();
        }
    }

}
