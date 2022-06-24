//Given the root of a binary tree and an integer targetSum, return true if the tree has a root-to-leaf path such that adding up all the values along the path equals targetSum.

//Definition for a binary tree node.
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution112
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        return h(root, targetSum);
    }
    public bool h(TreeNode root, int t)
    {
        if (root == null) return false;
        if (root.left == null && root.right == null)
        {
            if (t - root.val == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        return h(root.left, t - root.val) || h(root.right, t - root.val);
    }
}