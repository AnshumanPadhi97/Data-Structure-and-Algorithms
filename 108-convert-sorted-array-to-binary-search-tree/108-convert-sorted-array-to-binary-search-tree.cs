public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        if(nums.Length==0)return null;
        return h(nums,0,nums.Length-1);
    }
    public TreeNode h(int[] nums,int i,int j){
        if(i>j)return null;
        var mid = (i+j)>>1;
        var node = new TreeNode(nums[mid]);
        node.left = h(nums,i,mid-1);
        node.right = h(nums,mid+1,j);
        return node;
    }
}