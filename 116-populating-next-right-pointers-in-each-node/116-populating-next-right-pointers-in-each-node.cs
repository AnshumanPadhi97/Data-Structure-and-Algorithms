public class Solution {
    public Node Connect(Node root) {
        if(root==null)return null;
        var q = new Queue<Node>();
        q.Enqueue(root);
        while(q.Count>0){
            var l = q.Count;
            for(int i=0;i<l;i++){
                var a = q.Dequeue();
                if(i==l-1){
                    a.next=null;
                }else{
                    a.next=q.Peek();
                }
                if(a.left!=null)q.Enqueue(a.left);
                if(a.right!=null)q.Enqueue(a.right);
            }
        }
        return root;
    }
}