class Node:
    def __init__(self, val=0, neighbors=None) -> None:
        self.val = val
        self.neighbors = neighbors if neighbors is not None else []

class Solution:
    def CloneGraph(self, node):
        oldToNew = {}

        def clone(node):

            if  node in oldToNew:
                return oldToNew[node]
            
            copy = Node(node.val)
            oldToNew[node] = copy

            for nei in node.neighbors:
                copy.neighbors.append(clone(nei))

            return copy

        return clone(node) if node else None
