public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        while(head!=null){
            var next = head.next;
            head.next=prev;
            prev=head;
            head=next;
        }
        return prev;
    }
}