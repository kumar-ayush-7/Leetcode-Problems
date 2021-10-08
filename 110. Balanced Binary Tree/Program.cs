//110. Balanced Binary Tree
using System;

namespace _110._Balanced_Binary_Tree
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
        //Bottoms up approach O(n)
        public static bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            return Diff(root) != -1;
            
        }
        public static int Diff(TreeNode root)
        {
            if (root == null)
                return 0;
            int left = Diff(root.left);
            int right = Diff(root.right);
            int bf = Math.Abs(left - right);
            if (bf > 1 || left == -1 || right == -1)
                return -1;
            else
                return Math.Max(left, right) + 1;
        }

        //Top down approach O(n^2)
        //public static bool IsBalanced(TreeNode root)
        //{
        //    if (root == null)
        //        return true;
        //    if (Math.Abs(Diff(root.left) - Diff(root.right)) > 1)
        //        return false;
        //    else
        //        return IsBalanced(root.left) && IsBalanced(root.right);
        //}
        //public static int Diff(TreeNode root)
        //{
        //    if (root == null)
        //        return 0;
        //    return Math.Max( Diff(root.left), Diff(root.right)) + 1;
        //}
        static void Main(string[] args)
        {
            TreeNode root = GetNodeReference(1);
            TreeNode child1 = GetNodeReference(2);
            TreeNode child2 = GetNodeReference(2);

            TreeNode child3 = GetNodeReference(3);
            TreeNode child4 = GetNodeReference(3);
            TreeNode child5 = GetNodeReference(3);
            TreeNode child6 = GetNodeReference(17);
            TreeNode _7 = GetNodeReference(4);
            TreeNode _8 = GetNodeReference(4);

            root.left = child1;
            root.right = child2;
            child1.left = child3;
            child1.right = child4;
            child3.left = _7;
            child3.right = _8;

            Console.WriteLine(IsBalanced(root));
        }
    }
}
