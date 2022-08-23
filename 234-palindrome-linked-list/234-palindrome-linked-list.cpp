/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    bool isPalindrome(ListNode* head) {
        ListNode *mid = head;
        ListNode *temp = head;
        while(temp && temp->next){
            temp=temp->next;
            temp=temp->next;
            mid=mid->next;
        }
        ListNode *rev = reverse(mid);
        while(rev && head){
            if(rev->val!=head->val){
                return false;
            }
            rev=rev->next;
            head=head->next;
        }
        return true;
    }
    ListNode* reverse(ListNode* head){
        ListNode* prev=NULL;
        while(head){
            ListNode *next=head->next;
            head->next=prev;
            prev=head;
            head=next;
        }
        return prev;
    }
};