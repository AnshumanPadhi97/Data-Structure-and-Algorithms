/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        int l1 = 0, l2 = 0;
        var temp = headA;
        while(temp!=null){
            temp = temp.next;
            l1++;
        }
        temp=headB;
        while(temp!=null){
            temp=temp.next;
            l2++;
        }
        if(l1>l2){
            var diff = l1-l2;
            while(diff-->0){headA=headA.next;}
            while(headA!=null || headB!=null){
                if(headA==headB)return headA;
                headA=headA.next;
                headB=headB.next;
            }
        }else{
            var diff = l2-l1;
            while(diff-->0){headB=headB.next;}
            while(headA!=null || headB!=null){
                if(headA==headB)return headA;
                headA=headA.next;
                headB=headB.next;
            }
        }
        return null;
    }
}