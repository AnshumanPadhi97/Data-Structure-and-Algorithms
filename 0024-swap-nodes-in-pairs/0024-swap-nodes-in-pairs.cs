public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if(head==null || head.next==null)return head;
        
        var a = new ListNode();
        var prev = a;
        var curr = head;
        
        while(curr != null && curr.next!=null){
            prev.next=curr.next;
            curr.next=prev.next.next;
            prev.next.next = curr;
            
            prev=curr;
            curr=curr.next;
        }
        
        return a.next;
    }
}