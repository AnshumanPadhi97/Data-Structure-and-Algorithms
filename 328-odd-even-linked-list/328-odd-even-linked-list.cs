public class Solution {
    public ListNode OddEvenList(ListNode head) {
        var ol = new ListNode(0);
        var hol = ol;
        var el = new ListNode(0);
        var hel = el;
        int i=1;
        while(head!=null){
            if(i%2!=0){
                ol.next = new ListNode(head.val);
                ol=ol.next;
            }
            else{
                el.next = new ListNode(head.val);
                el=el.next;
            }
            head=head.next;
            i++;
        }
        hel=hel.next;
        ol.next=hel;
        return hol.next;
    }
}