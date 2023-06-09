﻿using System.Collections.Generic;

namespace Merge_Two_Sorted_Lists
{
        // * Definition for singly-linked list.

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
        #region Problem
        /*
          You are given the heads of two sorted linked lists list1 and list2.

          Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.

          Return the head of the merged linked list.



          Example 1:


          Input: list1 = [1,2,4], list2 = [1,3,4]
          Output: [1,1,2,3,4,4]
          Example 2:

          Input: list1 = [], list2 = []
          Output: []
          Example 3:

          Input: list1 = [], list2 = [0]
          Output: [0]


          Constraints:

          The number of nodes in both lists is in the range [0, 50].
          -100 <= Node.val <= 100
          Both list1 and list2 are sorted in non-decreasing order.
           */
        #endregion

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }
            if (list2 == null)
            {
                return list1;
            }

            if (list1.val >= list2.val)
            {
                ListNode tempNode = new ListNode(list1.val, list1.next);
                list1.val = list2.val;
                list1.next = tempNode;

                return MergeTwoLists(list1, list2.next);
            }
            else
            {
                list1.next = MergeTwoLists(list1.next, list2);
            }

            return list1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}