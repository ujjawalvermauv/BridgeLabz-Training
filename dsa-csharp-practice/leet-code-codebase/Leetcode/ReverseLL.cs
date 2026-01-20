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
    public ListNode ReverseList(ListNode head) {
        ListNode prev=null;
        ListNode curr=head;
        ListNode next=null;

        while(curr !=null){
            next=curr.next;
            curr.next= prev; // reverse link
            prev = curr;
            curr=next;
            
        }
        head=prev;
        return head;
        
    }
}