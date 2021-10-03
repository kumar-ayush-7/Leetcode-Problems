using System;

namespace _104._Maximum_Depth_of_Binary_Tree
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
        public static int len = 0, maxLen = 0;
        public static int MaxDepth(TreeNode root)
        {
            if (root != null)
            {
                ++len;
                MaxDepth(root.left);
                if (len > maxLen)
                    maxLen = len;
                MaxDepth(root.right);
                --len;
            }
            return maxLen;
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

            //root.left = child1;
            //child1.left = child3;
            //child2.left = child4;

            root.right = child2;
            //child1.right = child5;
            //child2.right = child6;


            Console.WriteLine(MaxDepth(root));
        }
    }
}
