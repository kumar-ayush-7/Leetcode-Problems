//https://leetcode.com/problems/remove-duplicates-from-sorted-list/
using System;

namespace _83._Remove_Duplicates_from_Sorted_List
{
    class Program
    {
        //Definition for singly-linked list.
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
        public static ListNode GetNodeInstance(int val = 0)
        {
            return new ListNode(val);
        }
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode current = head;
            while(current != null && current.next != null)
            {
                if (current.val == current.next.val)
                    current.next = current.next.next;
                else
                    current = current.next;
            }
            return head;

        }
        public static void PrintList(ListNode root)
        {
            do
            {
                Console.Write(root.val + " -> ");
                root = root.next;
            }
            while (root != null);
        }
        static void Main(string[] args)
        {
            ListNode Head = GetNodeInstance();
            ListNode node1 = GetNodeInstance(1);
            ListNode node2 = GetNodeInstance(1);
            ListNode node3 = GetNodeInstance(1);
            ListNode node4 = GetNodeInstance(3);
            ListNode node5 = GetNodeInstance(3);
            Head.next = node1;
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            PrintList(Head.next);
            Console.WriteLine();
            Head = DeleteDuplicates(Head);
            PrintList(Head.next);


        }
    }
}
