// See https://aka.ms/new-console-template for more information
using BinaryTree;

Console.WriteLine("Hello, World!");

Tree<int> binaryTree = new Tree<int>();

binaryTree.root = new Node<int>(1);

binaryTree.root.Left = new Node<int>(2);
binaryTree.root.Right = new Node<int>(3);