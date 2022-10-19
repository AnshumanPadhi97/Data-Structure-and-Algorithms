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
    public ListNode SortList(ListNode head) {
        if(head==null || head.next==null) return head;
        
        var s = head;
        var f = head;
        ListNode mid = null;
        while(f!=null && f.next!=null){
            mid=s;
            s=s.next;
            f=f.next.next;
        }
        mid.next=null;
        
        var l = SortList(head);
        var r = SortList(s);
        return merge(l,r);
    }
    
    ListNode merge(ListNode l,ListNode r){
        var temp = new ListNode(0);
        var res = temp;
        while(l!=null && r!=null){
            if(l.val>r.val){
                temp.next=r;
                r=r.next;
            }
            else{
                temp.next=l;
                l=l.next;
            }
            temp=temp.next;
        }
        if(l!=null){
            temp.next=l;
        }
        if(r!=null){
            temp.next=r;
        }
        return res.next;
    }
}