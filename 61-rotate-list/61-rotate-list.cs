public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if(head==null)return null;
        if(k==0)return head;
        
        var fast = head;
        var temp = head;
        int l=0;
        
        while(temp.next!=null){
            l++;
            temp=temp.next;
        }
        temp.next=head;
        l++;
        
        k%=l;
        
        for(int i=0;i<l-k;i++){
            temp=temp.next;
        }
        
        fast = temp.next;
        temp.next=null;
        
        return fast;
    }
}