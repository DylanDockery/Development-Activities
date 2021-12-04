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
    public ListNode Partition(ListNode head, int x) {
        ListNode LeftNodes = new ListNode();
        ListNode RightNodes = new ListNode();
        ListNode current=head;
        ListNode temp;
        
        while(current!=null){
            temp=current;
            current=current.next;
            temp.next=null;
            if(temp.val<x){
                Append(temp,LeftNodes);
                
            }
            else{
                Append(temp,RightNodes);
            }
        }
        current=LeftNodes;
        while(current.next!=null){
            current=current.next;
        }
        current.next=RightNodes.next;
        return LeftNodes.next;
        
    }
    
    public void Append(ListNode newNode, ListNode head){
        ListNode current=head;
        while(current.next!=null){
            current=current.next;
        }
        current.next=newNode;
        return;
    }
}