public class Solution {
    public ListNode MergeTwoLists(ListNode a, ListNode b) {
        if(a==null)return b;
        if(b==null)return a;
        if(a.val<=b.val){
            a.next=MergeTwoLists(a.next,b);
            return a;
        }else{
            b.next=MergeTwoLists(a,b.next);
            return b;
        }
    }
}