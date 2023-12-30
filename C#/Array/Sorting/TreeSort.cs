namespace Array.Sorting
{
    public class TreeSort
    {
        public void Main()
        {
            int[] arr = { 1, 2, 3 };
            BST tree = new BST();
            for (int i = 0; i < arr.Length; i++)
            {
                tree.Insert(arr[i]);
            }
            tree.InOrder(tree.root);

        }

        public class Node
        {
            public int Key;

            public Node Left;

            public Node Right;

            public Node(int key)
            {
                Key = key;
                Left = Right = null!;
            }
        }

        public class BST
        {
            public Node root;

            public BST()
            {
                root = default!;
            }

            public Node Insert(int key)
            {
                Node node = new Node(key);
                if (root == null)
                {
                    root = node;
                }
                else
                {
                    Node prev = null;
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
                return node;


            }

            internal void InOrder(Node root)
            {
                if (root != null)
                {
                    InOrder(root.Left);
                    Console.WriteLine(root.Key);
                    InOrder(root.Right);
                }
            }
        }
    }
}
