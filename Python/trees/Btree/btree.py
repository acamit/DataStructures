class BTreeNode:
    def __init__(self, leaf=False) -> None:
        self.leaf = leaf
        self.keys = []
        self.child = []

class BTree:
    def __init__(self, t) -> None:
        self.root = BTreeNode(True)
        self.t = t
    
    def insert(self, k):
        root = self.root

        if len(root.keys) == (2* self.t)- 1: # root is full
            temp = BTreeNode()
            self.root = temp
            temp.child.insert(0, root)
            self.split_child(temp, 0)
            self.insert_non_full(temp, k)
        else:
            self.insert_non_full(root, k)
    
    def insert_non_full(self, x, k):
        i = len(x.keys) - 1
        if x.leaf:
            x.keys.append((None, None))
            while i>=0 and k[0] < x.keys[i][0]:
                x.keys[i+1] = x.keys[i]
                i-=1
            x.keys[i+1] = k
        else:
            while i>=0 and k[0] < x.keys[i][0]:
                i-=1
            i+=1
            if len(x.child[i].keys) == 2 * self.t-1:
                self.split_child(x, i)
            self.insert_non_full(x.child[i], k)
    

    def split_child(self, node, indexofChild):
        t = self.t
        y = node.child[indexofChild]
        z = BTreeNode(y.leaf)
        node.child.insert(indexofChild+1, z)
        node.keys.insert(indexofChild, y.keys[t-1])
        z.keys = y.keys[t:(2*t)-1]
        y.keys = y.keys[0:t-1]

        if not y.leaf:
            z.child = y.child[t:2*t]
            y.child = y.child[0:t-1]


    def search(self, k, node=None):
        if node is not None:
            i = 0
            while i < len(node.keys) and k>node.keys[i][0]:
                i+=1
            if i < len(node.keys) and k == node.keys[i][0]:
                return (node, i)
            elif node.leaf:
                return None
            else:
                return self.search(k, node.child[i])
        else:
            return self.search(k, self.root)