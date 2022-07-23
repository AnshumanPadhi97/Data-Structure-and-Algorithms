public class Solution {
    public void ReorderList(ListNode head) {
        var s = head;
        var f = head;
        while(f!=null && f.next!=null){
            s=s.next;
            f=f.next.next;
        }
        var a = reverse(s);
        while(a!=null && head!=null){
            var temp = head.next;
            head.next=a;
            head = temp;
            
            temp = a.next;
            a.next=head;
            a=temp;
        }
        if(head!=null){
            head.next=null;
        }
    }
    public ListNode reverse(ListNode head){
        ListNode prev=null;
        while(head!=null){
            var next = head.next;
            head.next=prev;
            prev=head;
            head=next;
        }
        return prev;
    }
}