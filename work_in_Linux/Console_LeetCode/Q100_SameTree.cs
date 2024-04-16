

namespace Q100_SameTree
{
    public class MyComparer
    {
        public static bool compare(TreeNode p, TreeNode q)
        {
            // If both nodes are null, they are identical
            if (p == null && q == null)
                return true;

            // If one node is null and the other is not, they are not identical
            if (p == null || q == null)
                return false;

            // Check if current nodes' values are the same
            if (p.val != q.val)
                return false;

            // Recursively compare left and right subtrees
            return compare(p.left, q.left) && compare(p.right, q.right);
        }
    }

    public class Executor
    {

        public static void isSameTree()
        {
            // int[] arrP = { 1, 2, 1, };
            // int[] arrQ = { 1, 1, 2, };

            TreeNode tnP = new(1);
            tnP.left = new(2);
            // tnP.right = new(3);
            // Console.WriteLine("Inorder traversal: tnP");
            // BinaryTree.InorderTraversal(tnP);
            // Console.WriteLine();

            TreeNode tnQ = new(1);
            // tnQ.left = new(2);
            tnQ.right = new(2);
            // Console.WriteLine("Inorder traversal: tnQ");
            // BinaryTree.InorderTraversal(tnQ);
            // Console.WriteLine();

            bool res = MyComparer.compare(tnP, tnQ);
            Console.WriteLine($"res = {res}");
        }

    }
}


