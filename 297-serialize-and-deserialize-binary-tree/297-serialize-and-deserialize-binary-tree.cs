public class Codec {
    string a = ",";
    public string serialize(TreeNode root) {
        StringBuilder sb = new StringBuilder();
        h(root,sb);
        return sb.ToString();
    }
    public void h(TreeNode root,StringBuilder sb){
        if(root==null){
            sb.Append("#").Append(a);
        }else{
            sb.Append(root.val).Append(a);
            h(root.left,sb);
            h(root.right,sb);
        }
    }

    public TreeNode deserialize(string data) {
        return build(data.Split(a).ToList());
    }
    public TreeNode build(List<string> arr){
        var item = arr[0];
        arr.RemoveAt(0);
        if(item=="#"){
            return null;
        }
        else{
            var node = new TreeNode(int.Parse(item));
            node.left=build(arr);
            node.right=build(arr);
            return node;
        }
    }
}