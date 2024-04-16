
namespace Impl_BinaryTreeArray
{
    public class BinaryTreeArray
    {
        private int[] array; // 用于存储二叉树节点的数组
        private int lastIndex; // 当前数组中最后一个节点的索引

        public BinaryTreeArray(int capacity)
        {
            array = new int[capacity];
            lastIndex = -1; // 初始化时没有节点
        }

        // 向二叉树中插入新节点
        public void Insert(int value)
        {
            if (lastIndex < array.Length - 1)
            {
                lastIndex++;
                array[lastIndex] = value;
            }
            else
            {
                Console.WriteLine("Binary tree is full. Cannot insert more nodes.");
            }
        }

        // 前序遍历二叉树
        public void PreorderTraversal(int index)
        {
            if (index >= 0 && index <= lastIndex)
            {
                // 访问当前节点
                Console.Write(array[index] + " ");

                // 遍历左子树
                PreorderTraversal(2 * index + 1);

                // 遍历右子树
                PreorderTraversal(2 * index + 2);
            }
        }

        public static void Main()
        {
            BinaryTreeArray tree = new BinaryTreeArray(10);

            // 插入节点
            tree.Insert(1);
            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(5);
            tree.Insert(6);

            Console.WriteLine("Preorder traversal:");
            tree.PreorderTraversal(0); // 从根节点开始前序遍历

            Console.WriteLine();
        }
    }
}

