using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6.Algorithms
{

    public class uf
    {
        int[] parent = new int[0];
        int[] size = new int[0];
        int uniqueParents = 0;
        public uf(int n)
        {
            uniqueParents = n;
            parent = new int[n];
            size = new int[n];
            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
                size[i] = 1;
            }
        }
        public int find(int u)
        {
            if (u == parent[u])
            {
                return u;
            }
            else
            {
                return parent[u] = find(parent[u]);
            }
        }
        public bool union(int u, int v)
        {
            u = find(u);
            v = find(v);

            if (u == v) return false;
            if (size[u] > size[v])
            {
                parent[v] = u;
                size[u] += size[v];
            }
            else
            {
                parent[u] = v;
                size[v] += size[u];
            }
            uniqueParents -= 1;
            return true;
        }
    }
}
