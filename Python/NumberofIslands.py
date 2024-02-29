class Graph:
    def __init__(self, row, col, g) -> None:
        self.ROW = row
        self.COL = col
        self.graph = g
    
    def isSafe(self, i, j, visited):
        return i>=0 and i<self.ROW and \
        j>=0 and j<self.COL and \
        not visited[i][j] and self.graph[i][j]
    
    def DFS(self, i, j, visited):
        