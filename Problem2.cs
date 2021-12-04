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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode temp =new ListNode();
        temp.next=head;
        ListNode previous =temp;
        ListNode current =head;
        bool deleteNode =false;
        while(current!=null && current.next!=null){

            while(current.next!=null &&  current.val==current.next.val){
                current.next=current.next.next;
                deleteNode=true;
            }
            if (deleteNode){
                previous.next=current.next;
                current=current.next;
            }
           else{
                previous=previous.next;
                current=current.next;
           }
            deleteNode=false;
        }
       
        
        return temp.next;
    }
}