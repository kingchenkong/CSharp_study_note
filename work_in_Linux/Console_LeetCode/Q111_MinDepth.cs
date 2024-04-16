

namespace Q111_MinDepth
{
    public class Solution
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            Queue<(TreeNode, int)> queue = new Queue<(TreeNode, int)>();
            queue.Enqueue((root, 1));

            while (queue.Count > 0)
            {
                var (node, depth) = queue.Dequeue();
                // Dictionary<TreeNode, int> dict = queue.Dequeue();

                if (node.left == null && node.right == null)
                {
                    return depth; // Minimum depth.
                }

                // if not null, enqueue node
                if (node.left != null)
                {
                    queue.Enqueue((node.left, depth + 1));
                }
                if (node.right != null)
                {
                    queue.Enqueue((node.right, depth + 1));
                }
            }
            return 0; // error: not found leaf.
        }
    }

    public class Executor
    {
        public static void Main()
        {
            Solution solution = new();

            // -- node 1 =  [3,9,20,null,null,15,7]
            // TreeNode node = new(3);
            // node.left = new(9);
            // node.right = new(20);
            // node.right.left = new (15);
            // node.right.right = new(7);

            // -- node 2 = [2,null,3,null,4,null,5,null,6]
            TreeNode node = new(2);
            node.right = new(3);
            node.right.right = new(4);
            node.right.right.right = new(5);
            node.right.right.right.right = new(6);

            Console.WriteLine($"MinDepth: {solution.MinDepth(node)}");
        }
    }

    public class BinaryTree
    {
        private TreeNode root;

        public BinaryTree(TreeNode rootNode)
        {
            root = rootNode;
        }

        // 广度优先搜索（BFS）实现
        public void BFS()
        {
            if (root == null)
                return;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                Console.Write(node.val + " ");

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }
        }

        public static void Main()
        {
            // 创建一个二叉树
            TreeNode root = new(1);
            root.left = new(2);
            root.right = new(3);
            root.left.left = new(4);
            root.left.right = new(5);

            BinaryTree tree = new(root);

            Console.WriteLine("BFS traversal:");
            tree.BFS();
            Console.WriteLine();
        }
    }

}



