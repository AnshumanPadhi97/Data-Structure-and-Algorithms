public class Solution {
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        if(left==right)return head;
        
        ListNode curr=head,prev=null;
        
        for(int i=0;curr!=null && i<left-1; i++){
            prev=curr;
            curr=curr.next;
        }
        
        var lastNodeOfFirstPart = prev;
        var lastNodeOfSubList = curr;
        
        for(int i=0;curr!=null && i<right-left+1; i++){
            var next = curr.next;
            curr.next=prev;
            prev=curr;
            curr=next;
        }
        
        if(lastNodeOfFirstPart != null){
            lastNodeOfFirstPart.next=prev;
        }else{
            head=prev;
        }
        
        lastNodeOfSubList.next=curr;
        
        return head;
    }
}