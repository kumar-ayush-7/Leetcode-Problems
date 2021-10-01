using System;

namespace _100._Same_Tree
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

        //Using morris inorder traversal
        //public static IList<int> InorderTraversal(TreeNode root)
        //{
        //    IList<int> result = new List<int>();
        //    TreeNode current = root;
        //    // loop till current becomes null, i.e. till last node is traversed
        //    while (current != null)
        //    {
        //        // if there is no left sub tree log current node and move to right sub tree
        //        if (current.left == null)
        //        {
        //            result.Add(current.val);
        //            current = current.right;
        //        }
        //        else
        //        {
        //            // find predecessor to the current node
        //            TreeNode predecessor = current.left;
        //            while (predecessor.right != null && predecessor.right != current)
        //            {
        //                predecessor = predecessor.right;
        //            }
        //            // if the predecessor is traverserd first time link it to the current,
        //            // move current to current's left
        //            if (predecessor.right == null)
        //            {
        //                predecessor.right = current;
        //                current = current.left;
        //            }
        //            // if the predecessor is already linked to current, remove the link
        //            // log current node and move to the right
        //            else
        //            {
        //                predecessor.right = null;
        //                result.Add(current.val);
        //                current = current.right;
        //            }
        //        }
        //    }
        //    return result;

        //}

        //normal recursive method
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if ((p != null && q == null) || (p == null && q != null))
                return false;
            else if (p != null && q != null)
            {
                if (!IsSameTree(p.left, q.left))
                    return false;
                if (p.val != q.val)
                    return false;
                if (!IsSameTree(p.right, q.right))
                    return false;

            }
            return true;

        }
        static void Main(string[] args)
        {
            TreeNode root = GetNodeReference(1);
            TreeNode child1 = GetNodeReference(2);
            TreeNode child2 = GetNodeReference(3);
            root.right = child1;
            child1.left = child2;

            TreeNode root1 = GetNodeReference(1);
            TreeNode child11 = GetNodeReference(2);
            TreeNode child12 = GetNodeReference(3);
            root1.right = child11;
            child11.left = child12;

            Console.WriteLine(IsSameTree(root, root1));
        }
    }
}
