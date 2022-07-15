# You are given an m x n binary matrix grid. An island is a group of 1's (representing land) connected 4-directionally (horizontal or vertical.) You may assume all four edges of the grid are surrounded by water.
# The area of an island is the number of cells with a value 1 in the island.
# Return the maximum area of an island in grid. If there is no island, return 0.

# m == grid.length
# n == grid[i].length
# 1 <= m, n <= 50
# grid[i][j] is either 0 or 1.

from typing import List


class Solution:
    def maxAreaOfIsland(self, grid: List[List[int]]) -> int:
        maxArea = 0
        queue = []
        m = len(grid)
        n = len(grid[0])
        dirX = [-1,0,1,0]
        dirY = [0,1,0,-1]
        for i in range(m):
            for j in range(n):
                if grid[i][j] == 1:
                    current = 0
                    queue.append((i,j))
                    grid[i][j] = 0
                    while len(queue) > 0:
                        currentCell = queue.pop()
                        current +=1
                        for dir in range(4):
                            newI = currentCell[0] + dirX[dir]
                            newJ = currentCell[1] + dirY[dir]
                            if newI >=0 and newJ >=0 and newI < m and newJ < n and grid[newI][newJ]==1:
                                queue.append((newI,newJ))
                                grid[newI][newJ] = 0
                    maxArea = max(maxArea,current)
        return maxArea

solver = Solution()
print(solver.maxAreaOfIsland([
    [0,0,1,0,0,0,0,1,0,0,0,0,0],
    [0,0,0,0,0,0,0,1,1,1,0,0,0],
    [0,1,1,0,1,0,0,0,0,0,0,0,0],
    [0,1,0,0,1,1,0,0,1,0,1,0,0],
    [0,1,0,0,1,1,0,0,1,1,1,0,0],
    [0,0,0,0,0,0,0,0,0,0,1,0,0],
    [0,0,0,0,0,0,0,1,1,1,0,0,0],
    [0,0,0,0,0,0,0,1,1,0,0,0,0]])==6)

print(solver.maxAreaOfIsland([[0,0,0,0,0,0,0,0]])==0)
print(solver.maxAreaOfIsland([[0,1,0,0,0,0,0,0]])==1)
print(solver.maxAreaOfIsland([[0,1,0,0,0,0,0,1]])==1)