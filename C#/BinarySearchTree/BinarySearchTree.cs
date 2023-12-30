namespace BST
{
    public class Node
    {
        public int Key;
        public Node Left;
        public Node Right;

        public Node(int item)
        {
            Key = item;
            Left = Right = default!;
        }
    }

    public class BinarySearchTree
    {
        public Node root; // just used for iterative version of insert
        public Node insert(Node node, int key)
        {
            if (node == null)
            {
                return new Node(key);
            }

            if (key < node.Key)
            {
                node.Left = insert(node.Left, key);
            }
            else
            {
                node.Right = insert(node.Right, key);
            }
            return node;
        }

        public void InsertIterative(int key)
        {
            Node node = new Node(key);
            if (root == null)
            {
                root = node;
                return;
            }
            Node prev = null!;
            Node temp = root;

            while (temp != null)
            {
                prev = temp;
                if (key < temp.Key)
                {

                    temp = temp.Left;
                }
                else
                {
                    temp = temp.Right;
                }
            }
            if (key < prev.Key)
            {
                prev.Left = node;
            }
            else
            {
                prev.Right = node;
            }
        }

        public Node Search(Node root, int key)
        {
            if (root == null || root.Key == key)
            {
                return root!;
            }
            if (key < root.Key)
            {
                return Search(root.Left, key);
            }
            return Search(root.Right, key);
        }
    }
}
