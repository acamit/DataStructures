import sys

class Graph():
    def __init__(self, vertices) -> None:
        self.V = vertices

        self.graph = [[0 for column in range(vertices)]
                      for row in range(vertices)]
    
    def printSolution(self, dist):
        print("Vertex \tDistance from Source")
        for node in range(self.V):
            print(node, "\t", dist[node])

    
    def minDistance(self, dist, sptSet):
        min = sys.maxsize

        for u in range(self.V):
            if dist[u] < min and sptSet[u] == False:
                min = dist[u]
                min_index = u
        return min_index
    
    def dijkstra(self, src):
        dist = [sys.maxsize]* self.V
        dist[src] = 0
        sptSet = [False] * self.V

        for cout in range(self.V):
            x = self.minDistance(dist, sptSet)
            sptSet[x] = True

            # update the distance of the neighbours of the picked vertex if the current distance of that adjacent is greater than new distance 
            #and it is not yet included in the SPT.
            for y in range(self.V):
                if self.graph[x][y] > 0 and sptSet[y]==False and dist[y] > dist[x]+ self.graph[x][y]:
                                 dist[y] = dist[x] + self.graph[x][y]