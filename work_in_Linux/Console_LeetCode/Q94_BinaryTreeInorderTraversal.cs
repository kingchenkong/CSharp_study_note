

namespace Q94_BinaryTreeInorderTraversal
{
    public class BinaryTree
    {
        public List<int> list = new();

        public TreeNode? root;

        public BinaryTree(TreeNode root)
        {
            this.root = root;
        }

        public void InorderTraversal(TreeNode node)
        {
            if (node == null) return;

            // left tree node
            InorderTraversal(node.left);

            // current
            list.Add(node.val);

            // right tree node
            InorderTraversal(node.right);
        }

    }

    public class Solution
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }

            BinaryTree tree = new(root);
            tree.InorderTraversal(root);
            return tree.list;
        }

        public static void Main()
        {

            TreeNode tr = new(1);
            // tr.right = new(2);
            // tr.right.left = new(3);

            IList<int> res = InorderTraversal(tr);

            foreach (int i in res)
            {
                Console.WriteLine($"item = {i}");
            }
        }
    }

}

