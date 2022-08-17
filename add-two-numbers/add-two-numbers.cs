/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if(l1==null)return l2;
        if(l2==null)return l1;
        int c=0;
        ListNode res = new ListNode(0);
        var temp = res;
        while(l1!=null || l2!=null || c == 1){
            int s=0;
            if(l1!=null){
                s+=l1.val;
                l1=l1.next;
            }
            if(l2!=null){
                s+=l2.val;
                l2=l2.next;
            }
            s+=c;
            c=s/10;
            var a =new ListNode(s%10);
            res.next=a;
            res=res.next;
        }
        return temp.next;
    }
}