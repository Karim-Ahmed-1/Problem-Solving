namespace Middle_of_the_Linked_List
{
    #region Problem
    /*
     Given the head of a singly linked list, return the middle node of the linked list.

If there are two middle nodes, return the second middle node.

 

Example 1:


Input: head = [1,2,3,4,5]
Output: [3,4,5]
Explanation: The middle node of the list is node 3.
Example 2:


Input: head = [1,2,3,4,5,6]
Output: [4,5,6]
Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one.
 

Constraints:

The number of nodes in the list is in the range [1, 100].
1 <= Node.val <= 100
     */
    #endregion
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
        {
          this.val = val;
           this.next = next;
                 }
 }
    internal class Program
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode curr1 = head;
            ListNode curr2 = head;
            ListNode result = null;
            int counter1 = 0;
            int counter2 = 0;
            while (curr1 != null)
            {
                counter1++;
                curr1 = curr1.next;
            }
            while (curr2 != null)
            {
                if (counter2 == (counter1 / 2))
                {
                    result = curr2;
                }
                counter2++;
                curr2 = curr2.next;
            }
            return result;
        }
        static void Main(string[] args)
        {
           
        }
    }
}