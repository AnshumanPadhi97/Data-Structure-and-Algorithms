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
    public ListNode Partition(ListNode head, int x) {
        var a = new ListNode(0);
        var b = new ListNode(0);
        var p1=a;
        var p2=b;
        while(head!=null){
            if(head.val<x){
                p1=p1.next=head;
            }else{
                p2=p2.next=head;
            }
            head=head.next;
        }
        p2.next=null;
        p1.next=b.next;
        return a.next;
    }
}