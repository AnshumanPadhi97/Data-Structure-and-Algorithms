/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if(root==null)return "#,";
        return root.val+","+serialize(root.left)+serialize(root.right);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        int i=0;
        return h(data.Split(','),ref i);
    }
    public TreeNode h(string[] a,ref int i){
        if(a[i]=="#")return null;
        var root=new TreeNode(int.Parse(a[i]));
        if(++i<a.Length) root.left=h(a,ref i);
        if(++i<a.Length) root.right=h(a,ref i);
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));