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
        if (head == null) {
            return head;
        }

        ListNode reverse = new ListNode(head.val); 
        int i = 0;
        while (head != null) {
            Console.WriteLine(head.val);
            if (i == 0) {
                i++;
                head = head.next;
                continue;
            }
            ListNode value = new ListNode(head.val);
            value.next = reverse;
            reverse = value; 
            head = head.next;
        }

        return reverse;
    }
}
