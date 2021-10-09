using System;

namespace _112._Path_Sum
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
        public static bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;
            if (root.left == null && root.right == null && targetSum - root.val == 0)
                return true;

            return HasPathSum(root.left, targetSum - root.val)
                || HasPathSum(root.right, targetSum - root.val);
        }
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

            Console.WriteLine(HasPathSum(root, 6));
        }
    }
}
