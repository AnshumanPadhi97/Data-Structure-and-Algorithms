public class Solution {
    public int PairSum(ListNode head) {
        var ls = new List<int>();
        while(head!=null){
            ls.Add(head.val);
            head=head.next;
        }
        int i=0,j=ls.Count-1;
        var res= int.MinValue;
        while(i<j){
            res=Math.Max(res,ls[i]+ls[j]);
            i++;j--;
        }
        return res;
    }
}