using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicDS6._0_Algorithms_and_Templates
{
    internal class TreeToGraph
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { this.val = x; this.left = this.right = null; }
        }

        Dictionary<TreeNode, List<TreeNode>> g = new Dictionary<TreeNode, List<TreeNode>>();
        public void build(TreeNode root, TreeNode parent)
        {
            if (root == null)
            {
                return;
            }
            if (!g.ContainsKey(root))
            {
                g[root] = new List<TreeNode>();
                if (parent != null)
                {
                    g[parent].Add(root);
                    g[root].Add(parent);
                }
                build(root.left, root);
                build(root.right, root);
            }
        }
    }
}
