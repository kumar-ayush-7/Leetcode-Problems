//https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
using System;

namespace _108._Convert_Sorted_Array_to_Binary_Search_Tree
{
    class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public static TreeNode GetNodeReference(int val = 0)
        {
            return new TreeNode(val);
        }
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            int len = nums.Length;
            if (len == 1)
                return GetNodeReference(nums[0]);
            return AddToBST(nums, 0, len - 1);
           
        }
        public static TreeNode AddToBST(int[] nums, int left, int right)
        {
            if (left > right)
                return null;
            int mid = left + (right - left) / 2;
            TreeNode root = GetNodeReference(nums[mid]);
            root.left = AddToBST(nums, left, mid - 1);
            root.right = AddToBST(nums, mid + 1, right);
            return root;
        }
        static void Main(string[] args)
        {
            int[] nums = { -10, -3, 0, 5, 9 };
        Console.WriteLine(SortedArrayToBST(nums));
        }
    }
}
