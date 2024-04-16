
namespace Q101_SymmetricTree
{
    public class Solution
    {
        public static bool CheckLeftAndRight(TreeNode? leftNode, TreeNode? rightNode)
        {
            // same null
            if (leftNode == null && rightNode == null) return true;

            // null, but different
            if (leftNode == null || rightNode == null) return false;

            // Check value of L R is same
            // Recursively compare:
            //  left(subtree).left == right(subtree).right
            //  left(subtree).right == right(subtree).left 
            return (leftNode.val == rightNode.val) &&
                CheckLeftAndRight(leftNode.left, rightNode.right) &&
                CheckLeftAndRight(leftNode.right, rightNode.left);
        }

        public static bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            return CheckLeftAndRight(root.left, root.right);
        }
    }

    public class Executor
    {
        public static void Run()
        {
            // -- root 1
            // TreeNode root = new(1)
            // {
            //     left = new(2),
            //     right = new(2)
            // };
            // root.left.left = new(3);
            // root.left.right = new(4);
            // root.right.left = new(4);
            // root.right.right = new(3);


            // -- root 2
            TreeNode root = new(1)
            {
                left = new(2),
                right = new(2)
            };
            root.left.right = new(3);
            root.right.right = new(3);

            bool res = Solution.IsSymmetric(root);

            Console.WriteLine($"res = {res}");
        }
    }
}


