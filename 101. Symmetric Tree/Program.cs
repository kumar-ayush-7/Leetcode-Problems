using System;
using System.Collections.Generic;

namespace _101._Symmetric_Tree
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
        public static bool IsSymmetric(TreeNode root)
        {
            return Symmetric(root, root);
        }
        public static bool Symmetric(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
                return true;
            if (t1 == null || t2 == null)
                return false;
            else
                return (t1.val == t2.val) && Symmetric(t1.left, t2.right) && Symmetric(t1.right, t2.left);
        }
        static void Main(string[] args)
        {
            TreeNode root = GetNodeReference(1);
            TreeNode child1 = GetNodeReference(2);
            TreeNode child2 = GetNodeReference(2);

            TreeNode child3 = GetNodeReference(3);
            TreeNode child4 = GetNodeReference(4);
            TreeNode child5 = GetNodeReference(4);
            TreeNode child6 = GetNodeReference(3);

            root.left = child1;
            child1.left = child3;
            child2.left = child4;

            root.right = child2;
            child1.right = child5;
            child2.right = child6;


            Console.WriteLine(IsSymmetric(root));
        }
    }
}
