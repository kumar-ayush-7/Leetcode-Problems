//https://leetcode.com/problems/minimum-depth-of-binary-tree/
using System;

namespace _111._Minimum_Depth_of_Binary_Tree
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
        //better approach
        public static int Mindepth(TreeNode root)
        {
            if (root == null)
                return 0;
            int left = Mindepth(root.left);
            int right = Mindepth(root.right);
            return (left == 0 || right == 0) ? left + right + 1 : Math.Min(left, right) + 1;
        }

        //novice approach 
        //public int min = int.maxvalue;
        //public static int mindepth(TreeNode root)
        //{
        //    if (root == null)
        //        return 0;
        //    program p = new program();
        //    int depth = 1;
        //    min(root, depth, p);
        //    return p.min;
        //}
        //public static void min(treenode root, int depth, program p)
        //{
        //    if (root.left == null && root.right == null && depth < p.min)
        //        p.min = depth;
        //    else
        //    {
        //        if (root.left != null)
        //            min(root.left, depth + 1, p);
        //        if (root.right != null)
        //            min(root.right, depth + 1, p);
        //    }

        //}
        static void Main(string[] args)
        {
            TreeNode root = GetNodeReference(3);
            TreeNode child1 = GetNodeReference(9);
            TreeNode child2 = GetNodeReference(20);

            TreeNode child3 = GetNodeReference(3);
            TreeNode child4 = GetNodeReference(3);
            TreeNode child5 = GetNodeReference(15);
            TreeNode child6 = GetNodeReference(7);
            TreeNode _7 = GetNodeReference(4);
            TreeNode _8 = GetNodeReference(4);

            root.left = child1;
            root.right = child2;
            child1.left = child3;
            child1.right = child4;
            //child2.left = child5;
            //child2.right = child6;
            //child3.left = _7;
            //child3.right = _8;

            Console.WriteLine(Mindepth(root));
        }
    }
}
