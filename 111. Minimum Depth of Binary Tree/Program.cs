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
        public int min = int.MaxValue;
        public static int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            Program p = new Program();
            int depth = 1;
            Min(root, depth, p);
            return p.min;
        }
        public static void Min(TreeNode root, int depth, Program p)
        {
            if (root.left == null && root.right == null && depth < p.min)
                p.min = depth;
            else
            {
                if (root.left != null)
                    Min(root.left, depth + 1, p);
                if (root.right != null)
                    Min(root.right, depth + 1, p);
            }

        }
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

            Console.WriteLine(MinDepth(root));
        }
    }
}
