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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        var res = new ListNode(0);
        var ans = res;
        if(l1==null)return l2;
        if(l2==null)return l1;
        while(l1!=null && l2!=null){
            if(l1.val>l2.val){
                res.next=l2;
                l2=l2.next;
            }else{
                res.next=l1;
                l1=l1.next;
            }
            res=res.next;
        }
        if(l1!=null){
            res.next=l1;
        }
        if(l2!=null){
            res.next=l2;
        }
        return ans.next;
    }
}