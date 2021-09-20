// https://leetcode.com/problems/merge-two-sorted-lists/
using System;

namespace _21._Merge_Two_Sorted_Lists
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

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
                return null;
            else if (l1 == null)
                return l2;
            else if (l2 == null)
                return l1;
            ListNode ptr = new ListNode(int.MinValue), res;
            if(l1.val > l2.val)
            {
                ptr.next = l2;
                l2 = l2.next;
            }
            else
            {
                ptr.next = l1;
                l1 = l1.next;
            }
            res = ptr;
            ptr = ptr.next;

            while(l1 != null && l2 != null)
            {
                if (l1.val > l2.val)
                {
                    ptr.next = l2;
                    l2 = l2.next;
                }
                else
                {
                    ptr.next = l1;
                    l1 = l1.next;
                }
                ptr = ptr.next;
            }
            if (l1 != null)
                ptr.next = l1;
            else
                ptr.next = l2;
            return res.next;

        }
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(5);
            ListNode l11 = new ListNode(10);
            ListNode l12 = new ListNode(15);
            ListNode l13 = new ListNode(20);
            l1.next = l11;
            l11.next = l12;
            l12.next = l13;

            ListNode l2 = new ListNode(-56);
            ListNode l21 = new ListNode(12);
            ListNode l22 = new ListNode(17);
            ListNode l23 = new ListNode(22);
            l2.next = l21;
            l21.next = l22;
            l22.next = l23;
            ListNode ptr;
            Console.Write("List 1 : ");
            ptr = l1;
            while (ptr != null)
            {
                Console.Write($" {ptr.val} ->");
                ptr = ptr.next;
            }
            Console.Write("\nList 2 : ");
            ptr = l2;
            while (ptr != null)
            {
                Console.Write($" {ptr.val} ->");
                ptr = ptr.next;
            }
            Console.Write("\nMerged sorted list : ");
            ptr = MergeTwoLists(l1,  l2);
            while (ptr != null)
            {
                Console.Write($" {ptr.val} ->");
                ptr = ptr.next;
            }
        }
    }
}
