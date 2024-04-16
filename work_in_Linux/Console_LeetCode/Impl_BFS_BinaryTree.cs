
namespace Impl_BFS_BinaryTree
{
    public class BinaryTree
    {
        private readonly TreeNode root;

        public BinaryTree(TreeNode rootNode)
        {
            root = rootNode;
        }

        public void BFS_useQueue()
        {
            if (root == null)
                return;

            Queue<TreeNode> queue = new();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                Console.Write(node.val + " ");

                // Enqueue left child if exists
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                // Enqueue right child if exists
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
        }

        public void BFS_useLoop()
        {
            if (root == null)
                return;

            int level = 0; // root level
            while (PrintNodesAtLevel(root, level))
            {
                level++;
            }
        }

        private bool PrintNodesAtLevel(TreeNode? node, int level)
        {
            if (node == null)
                return false;

            if (level == 0)
            {
                Console.Write(node.val + " ");
                return true;
            }

            bool left = PrintNodesAtLevel(node.left, level - 1);
            bool right = PrintNodesAtLevel(node.right, level - 1);

            return left || right;
        }

        public static void Test()
        {
            // Create a binary tree
            TreeNode root = new(1)
            {
                left = new(2),
                right = new(3)
            };
            root.left.left = new(4);
            root.left.right = new(5);
            root.right.left = new(6);
            root.right.right = new(7);

            BinaryTree tree = new(root);

            // Perform BFS traversal
            Console.WriteLine("Traversal BFS use Queue: ");
            tree.BFS_useQueue();
            Console.WriteLine();

            Console.WriteLine("Traversal BFS use Loop: ");
            tree.BFS_useLoop();
            Console.WriteLine();

        }
    }
}



