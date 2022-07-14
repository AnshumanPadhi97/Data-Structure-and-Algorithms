public class Solution {
    public bool IsPalindrome(ListNode head) {        
        var s = head;
        var f = head;
        
        while(f!=null && f.next!=null){
            s=s.next;
            f=f.next.next;
        }
        
        var a = reverse(s);
        
        while(a!=null && head!=null){
            if(a.val!=head.val)return false;
            a=a.next;
            head=head.next;
        }
        return true;
    }
    public ListNode reverse(ListNode head){
        ListNode prev= null;
        while(head!=null){
            var next = head.next;
            head.next=prev;
            prev=head;
            head=next;
        }
        return prev;
    }
}