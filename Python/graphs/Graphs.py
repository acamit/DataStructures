from collections import defaultdict

class Graph:
    def __init__(self) -> None:
        self.graph = defaultdict(list)
        self.visited = []
    
    def addEdge(self, u, v):
        self.graph[u].append(v)
    

    def BFS(self, s):
        visited = []
        queue = []
        visited.append(s)
        queue.append(s)

        while self.queue:
            m = self.queue.pop(0)

            print(m, end = " ")

            for neighbour in self.graph[m]:
                if neighbour not in self.visited:
                    self.visited.append(neighbour)
                    self.queue.append(neighbour)
    

    def DFS(self, v):
        visited = set()
        self.DFSUtility(v, visited)


    def DFSUtility(self, v, visited):
        visited.add(v)
        print(v, end=" ")

        for neighbour in self.graph[v]:
            if neighbour not in visited:
                self.DFSUtility(neighbour, visited)





import queue

def Edge(adj, v1, v2):
    adj[v1].append(v2)
    adj[v2].append(v1)


def BFS(v1, adj , visited):
    queue_of_vertices = queue.Queue()

    queue_of_vertices.put(v1)

    visited[v1] = True

    while( not queue_of_vertices.empty()):
        v1 = queue_of_vertices.queue[0]

def main():
    n = 7
    adj = [[]for i in range(n)]
    Edge(adj, 0, 1)
    Edge(adj, 0, 2)
    Edge(adj, 1, 2)
    Edge(adj, 1, 3)
    Edge(adj, 2, 3)
    Edge(adj, 4, 5)
    Edge(adj, 4, 6)

    visited = [False for i in range(n)]

    for vertex in range(n):
        if not visited[vertex]:
            BFS(vertex, adj, visited)
