from typing import List
import collections


class Solution:
    def numIslands(self, grid:List[List[str]])-> int:
        if not grid:
            return 0
        rows, cols = len(grid), len(grid[0])
        visited = set()
        islands = 0

        def bfs(r, c):
            q = collections.deque()
            visited.add((r,c))
            q.append((r, c))

            while q:
                row, col = q.popleft() # change to pop for dfs
                directions = [[1, 0], [-1, 0], [0, 1], [0, -1]]
                for dr, dc in directions:
                    c = col+dc
                    r = row+dr
                    if row+dr<rows and col+dc<cols \
                        and grid[r][c] == "1"\
                        and (r, c) not in visited:
                            visited.add((r, c))
                            q.append((r, c))


        for r in range(rows):
            for c in range(cols):
                if grid[r][c] == "1" and grid[r][c] not in visited:
                    bfs(r, c)
                    islands+=1
        return islands