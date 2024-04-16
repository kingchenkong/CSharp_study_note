

namespace Impl_CompleteBinaryTree
{
    public class BinaryTree
    {
        private readonly TreeNode root;

        public BinaryTree(TreeNode rootNode)
        {
            root = rootNode;
        }

        /*
        判定完全二元樹：
         使用廣度優先搜尋（BFS），從根節點開始逐層遍歷。
         在遍歷過程中，遇到一個節點的左子節點為空但右子節點不為空，則不是完全二元樹。
         如果遇到了一個節點，後面還有非空節點，則也不是完全二元樹。
        */
        public bool IsCompleteBinaryTree()
        {
            if (root == null) return true;

            Queue<TreeNode?> queue = new();
            queue.Enqueue(root);
            bool reachedEnd = false;

            while (queue.Count > 0)
            {
                TreeNode? node = queue.Dequeue();

                if (node == null)
                {
                    reachedEnd = true; // tag this node is null
                }
                else
                {
                    // If an empty node has been encountered but the current node is not empty
                    //  => It's not a complete binary tree.
                    if (reachedEnd) return false;

                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            }

            return true;
        }

        public static void Main()
        {

            /*
            example: It is a CBT.
                  1
                /   \
               2     3
              / \   / \
             4   5 6 
            */
            TreeNode root = new(1)
            {
                left = new(2),
                right = new(3)
            };
            root.left.left = new(4);
            root.left.right = new(5);
            root.right.left = new(6);

            BinaryTree tree = new(root);

            // Check is 'Complete Binary Tree' or not
            bool isComplete = tree.IsCompleteBinaryTree();
            Console.WriteLine("Is the binary tree a complete binary tree?\n" + isComplete); // 应该输出 true
        }
    }

}
