public class Solution {
    public ListNode DeleteMiddle(ListNode head) {
        if(head.next==null) return null;
        var s=head;
        var f=head.next.next;
        while(f!=null && f.next!=null){
            f=f.next.next;
            s=s.next;
        }
        s.next=s.next.next;
        return head;
    }
}