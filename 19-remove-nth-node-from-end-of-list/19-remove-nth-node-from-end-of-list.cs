public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var a=head;
        var b=head;
        while(n-->0){
            b=b.next;
        }
        if(b==null)return head.next;
        while(b.next!=null){
            a=a.next;
            b=b.next;
        }
        a.next=a.next.next;
        return head;
    }
}