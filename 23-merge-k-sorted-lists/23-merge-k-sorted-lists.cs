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
    public ListNode MergeKLists(ListNode[] lists) {
        int l = lists.Length;
        if(l==0)return null;
        if(l==1)return lists[0];
        var temp = new ListNode(0);
        temp = h(lists[0],lists[1]);
        for(int i=2;i<l;i++){
            temp = h(lists[i],temp);
        }
        return temp;
    }
    public ListNode h(ListNode list1,ListNode list2){
        var temp = new ListNode(0);
        var head=temp;
        if(list1==null)return list2;
        if(list2==null)return list1;
        while(list1!=null && list2!=null){
            if(list1.val>list2.val){
                temp.next=list2;
                list2=list2.next;
            }else{
                temp.next=list1;
                list1=list1.next;
            }
            temp=temp.next;
        }
        if(list1!=null){
            temp.next=list1;
        }
        if(list2!=null){
            temp.next=list2;
        }
        return head.next;
    }
}