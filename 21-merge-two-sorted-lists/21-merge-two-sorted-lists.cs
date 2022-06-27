public class Solution {
    public ListNode MergeTwoLists(ListNode a, ListNode b) {
        if(a==null)return b;
        if(b==null)return a;
        var temp = new ListNode(0);
        var h = temp;
        while(a!=null && b!=null){
            if(a.val>b.val){
                temp.next=b;
                b=b.next;
            }else{
                temp.next=a;
                a=a.next;
            }
            temp=temp.next;
        }
        if(a!=null){
            temp.next=a;
        }
        if(b!=null){
            temp.next=b;
        }
        return h.next;
    }
}