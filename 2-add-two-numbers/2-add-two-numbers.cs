public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if(l1==null)return l2;
        if(l2==null)return l1;
        var h = new ListNode(0);
        var t = h;
        int c=0;
        while(l1!=null || l2!=null){
            int a = l1!=null?l1.val:0;
            int b = l2!=null?l2.val:0;
            int sum = a+b+c;
            c=sum/10;
            t.next = new ListNode(sum%10);
            t=t.next;
            if(l1!=null)
                l1=l1.next;
            if(l2!=null)
                l2=l2.next;
        }
        if(c>0){
            t.next=new ListNode(c);
        }
        return h.next;
    }
}