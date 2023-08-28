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
public class Solution 
{
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        int            _indiceToRemove;
        ListNode       _currentNode;
        List<int>      nodes = new List<int>();
        while(true)
        {
            if(head.next)
            {
                _currentNode = head.next;
                nodesValues.Add(head.val);
                continue;
            }

            break;
        }
        _indiceToRemove = nodesValues.Count - n;

        nodesValues.RemoveAt(_indiceToRemove);

        return nodesValues;
    }
}
