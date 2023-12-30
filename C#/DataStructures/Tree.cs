namespace BinaryTree
{
    public class Tree<T>
    {
        public Node<T> root;
        public Tree(T key)
        {
            root = new Node<T>(key);
        }

        public Tree()
        {
            root = null;
        }

        int height(Node<T> node)
        {
            return 1 + Math.Max(height(node.Left), height(node.Right));
        }

        int Diameter(Node<T> node, Height height)
        {
            if (node == null)
            {
                height.h = 0;
                return 0;
            }

            var lH = new Height();
            var rH = new Height();


            int ld = Diameter(node.Left, lH);
            int hd = Diameter(node.Right, rH);

            height.h = Math.Max(lH.h, rH.h) + 1;

            return Math.Max(Math.Max(ld, hd), lH.h + rH.h + 1);
        }

        int Diameter()
        {
            Height h = new Height();
            return Diameter(root, h);
        }

        public void inorder(Node<T> temp)
        {
            if (temp == null)
            {
                return;
            }
            inorder(temp.Left);
            Console.WriteLine(temp.val);
            inorder(temp.Right);
        }

        public void insert(Node<T> temp, T key)
        {
            if (temp == null)
            {
                root = new Node<T>(key);
                return;
            }

            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(temp);

            while (queue.Count != 0)
            {
                temp = queue.Peek();
                queue.Dequeue();

                if (temp.Left == null)
                {
                    temp.Left = new Node<T>(key);
                    break;
                }
                else
                {
                    queue.Enqueue(temp.Left);
                }

                if (temp.Right == null)
                {
                    temp.Right = new Node<T>(key);
                    break;
                }
                else
                {
                    queue.Enqueue(temp.Right);
                }

            }
        }

        public void deleteDeepest(Node<T> root, Node<T> delNode)
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(root);
            Node<T> temp;

            while (queue.Count != 0)
            {
                temp = queue.Peek();
                queue.Dequeue();

                if (temp == delNode)
                {
                    temp = null;
                    return;
                }
                if (temp.Right != null)
                {
                    if (temp.Right == delNode)
                    {
                        temp.Right = null;
                        return;
                    }
                    else
                    {
                        queue.Enqueue(temp.Right);
                    }
                }

                if (temp.Left != null)
                {
                    if (temp.Left == delNode)
                    {
                        temp.Left = null;
                        return;
                    }
                    else
                    {
                        queue.Enqueue(temp.Left);
                    }
                }
            }
        }
        public void Delete(Node<T> root, T key)
        {
            if (root == null)
            {
                return;
            }
            // if single element in tree
            if (root.Left == null && root.Right == null)
            {
                if (root.val.Equals(key))
                {
                    root = null;
                }
                return;
            }

            Queue<Node<T>> queue = new Queue<Node<T>>();

            queue.Enqueue(root);

            Node<T> temp = null;
            Node<T> keyNode = null;

            /*identify the key node while doing level order traversal. 
             * Last element in the queue will be the deepest element in the tree. 
             */
            while (queue.Count > 0)
            {
                temp = queue.Peek();
                queue.Dequeue();

                if (temp.val.Equals(key))
                {
                    keyNode = temp;
                }

                if (temp.Left != null)
                    queue.Enqueue(temp.Left);

                if (temp.Right != null)
                {
                    queue.Enqueue(temp.Right);
                }
            }
            if (keyNode != null)
            {
                var x = temp.val;
                deleteDeepest(root, temp);
                keyNode.val = x;
            }
        }


    }
}
