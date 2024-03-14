# Binary Search Tree
class Node:
    def __init__(self, key) -> None:
        self.key = key
        self.left = None
        self.right = None


def insert(node, key):
    if node is None:
        return Node(key)
    
    if key < node.key:
        node.left = insert(node.left, key)
    elif key> node.key:
        node.right = insert(node.right, key)

    return node


def inorder(root):
    if root is not None:
        inorder(root.left)
        print(root.key, end=" ")
        inorder(root.right)


def height(node):
    if node is None:
        return 0
    else:
        lDepth = height(node.left)
        rDepth = height(node.right)

        return max(lDepth, rDepth) + 1


def printGivenLevel(root, level):
    if root is None:
        return
    
    if level == 1:
        print(root.key, end=" ")
    elif level > 1:
        printGivenLevel(root.left, level-1)
        printGivenLevel(root.right, level-1)
  

def printLevelOrder(root):
    h = height(root)
    for i in range(1, h+1):
        printGivenLevel(root, i)


def rightViewUtil(root, level, max_level):
    if root is None:
        return
    
    if max_level[0] < level:
        print("\t", root.key, end="")
        max_level[0] = level
    
    rightViewUtil(root.right, level+1, max_level)
    rightViewUtil(root.left, level+1, max_level)


def rightView(root):
    max_level = [0]
    rightViewUtil(root, 1, max_level)


def MinValueNode(node):
    current = node
    while current and current.left is not None:
        current = current.left
    
    return current

def deleteNode(root, key):
    if root is None:
        return root
    
    if key < root.key:
        root.left = deleteNode(root.left, key)
    
    elif key > root.key:
        root.right = deleteNode(root.right, key)
    
    else:
        if root.left is None:
            temp = root.right
            root = None
            return temp
        elif root.right is None:
            temp = root.left
            root = None
            return temp

        temp = MinValueNode(root.right)

        root.key = temp.key
        root.right = deleteNode(root.right, temp.key)

