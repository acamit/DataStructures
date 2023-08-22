namespace BinaryTree
{
    public class Node<T>
    {
        public T val;
        public Node<T> Left;
        public Node<T> Right;

        public Node(T item)
        {
            val = item;
            Left = Right = null;
        }
    }
}
