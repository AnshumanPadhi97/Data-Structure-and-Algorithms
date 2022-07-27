public class Solution {
    public void Flatten(TreeNode root) {
        while(root!=null){            
            if(root.left!=null)
            {
                var p = root.left;
                
                //go utmost right of left child
                while(p.right!=null){
                    p=p.right;
                }
                
                //put root right into curr utmost child right
                p.right=root.right;
                
                //update new root right
                root.right=root.left;
                
                //remove left link
                root.left=null;
            }
            //go right as left is null
            root=root.right;
        }
    }
}