namespace Linked_List_Cycle_II
{
     //* Definition for singly-linked list.
  public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int x)
        {
            val = x;
           next = null;
                 }
  }

    internal class Program
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null) return null;

            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {

                fast = fast.next.next;
                slow = slow.next;

                if (fast == slow)
                {
                    slow = head;
                    while (fast != slow)
                    {
                        fast = fast.next;
                        slow = slow.next;
                    }
                    return slow;
                }
            }

            return null;

        }
        static void Main(string[] args)
        {
           
        }
    }
}