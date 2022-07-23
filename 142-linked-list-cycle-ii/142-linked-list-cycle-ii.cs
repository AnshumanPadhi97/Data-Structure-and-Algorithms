public class Solution {
    public ListNode DetectCycle(ListNode head) {
        var s = head;
        var f = head;
        while(f!=null && f.next!=null){
            s=s.next;
            f=f.next.next;
            if(s==f){
                break;
            }
        }
        if(f==null || f.next==null)return null;
        while(head!=s){
            head=head.next;
            s=s.next;
        }
        return head;
    }
}