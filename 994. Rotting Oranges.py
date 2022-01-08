# You are given an m x n grid where each cell can have one of three values:
#     0 representing an empty cell,
#     1 representing a fresh orange, or
#     2 representing a rotten orange.
# Every minute, any fresh orange that is 4-directionally adjacent to a rotten orange becomes rotten.
# Return the minimum number of minutes that must elapse until no cell has a fresh orange. If this is impossible, return -1.

# m == grid.length
# n == grid[i].length
# 1 <= m, n <= 10
# grid[i][j] is 0, 1, or 2.

from typing import List


class Solution:
    def orangesRotting(self, grid: List[List[int]]) -> int:
        queue = []
        m=len(grid)
        n=len(grid[0])
        t=0
        for i in range(m):
            for j in range(n):
                if grid[i][j] == 2:
                    queue.append((i,j,t))
        while queue:
            x, y, t = queue.pop(0)
            for i,j in [(x-1,y),(x+1,y),(x,y-1),(x,y+1)]:
                    if (i>=0 and i<m and j>=0 and j<n and grid[i][j]==1):
                        queue.append((i,j,t+1))
                        grid[i][j]=2

        for i in range(m):
            for j in range(n):
                if grid[i][j] == 1:
                    return -1
        return t

solver = Solution()
print(solver.orangesRotting([[2,1,1],[1,1,0],[0,1,1]])==4)
print(solver.orangesRotting([[2,1,1],[0,1,1],[1,0,1]])==-1)