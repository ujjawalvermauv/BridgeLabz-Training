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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        // calculate size

        int size=0;
        ListNode temp=head;
        while(temp !=null){
            temp=temp.next;
            size++;
        }

        if(n==size){ // if it is present at 1st node
            head=head.next;
            return head;
        }

        // size-n+1

        int i=1;
        int iToFind=size-n;
        ListNode prev=head;
        while(i<iToFind){
            prev=prev.next;
            i++;
        }
        prev.next=prev.next.next;
        return head;


        
    }
}