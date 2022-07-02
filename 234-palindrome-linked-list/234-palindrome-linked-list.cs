public class Solution {
    public bool IsPalindrome(ListNode head) {
        var fast = head;
        var st = new Stack<int>();
        while(fast!=null){
            st.Push(fast.val);
            fast=fast.next;
        }
        while(head!=null){
            if(st.Pop() == head.val){
                head=head.next;
            }else{
                return false;
            }
        }
        return true;
    }
}