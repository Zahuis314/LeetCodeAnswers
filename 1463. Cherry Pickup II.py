# You are given a rows x cols matrix grid representing a field of cherries where grid[i][j] represents the number of cherries that you can collect from the (i, j) cell.
# You have two robots that can collect cherries for you:
#     Robot #1 is located at the top-left corner (0, 0), and
#     Robot #2 is located at the top-right corner (0, cols - 1).
# Return the maximum number of cherries collection using both robots by following the rules below:
#     From a cell (i, j), robots can move to cell (i + 1, j - 1), (i + 1, j), or (i + 1, j + 1).
#     When any robot passes through a cell, It picks up all cherries, and the cell becomes an empty cell.
#     When both robots stay in the same cell, only one takes the cherries.
#     Both robots cannot move outside of the grid at any moment.
#     Both robots should reach the bottom row in grid.

# rows == grid.length
# cols == grid[i].length
# 2 <= rows, cols <= 70
# 0 <= grid[i][j] <= 100

from typing import List
from functools import *

class Solution:
    def cherryPickup(self, grid: List[List[int]]) -> int:
        m = len(grid)
        n = len(grid[0])
        @lru_cache(None)
        def dynamicCherryPickup( x: int, y1: int, y2: int) -> int:
            if y1<0 or y1>=n or y2<0 or y2>=n:
                return float("-inf")
            curr = grid[x][y1] + grid[x][y2] if y1!=y2 else grid[x][y1]
            if x != m-1:
                curr += max(dynamicCherryPickup(x+1,y1_new,y2_new) for y1_new in [y1-1,y1,y1+1] for y2_new in [y2-1,y2,y2+1])
            return curr
        return dynamicCherryPickup( 0, 0, len(grid[0])-1)

        
solver = Solution()
print(solver.cherryPickup([
    [3,1,1],
    [2,5,1],
    [1,5,5],
    [2,1,1]])==24)
print(solver.cherryPickup([
    [1,0,0,0,0,0,1],
    [2,0,0,0,0,3,0],
    [2,0,9,0,0,0,0],
    [0,3,0,5,4,0,0],
    [1,0,2,3,0,0,6]])==28)
print(solver.cherryPickup([
    [8,8,10,9,1,7],
    [8,8, 1,8,4,7],
    [8,6,10,3,7,7],
    [3,0, 9,3,2,7],
    [6,8, 9,4,2,5],
    [1,1, 5,8,8,1],
    [5,6, 5,2,9,9],
    [4,4, 6,2,5,4],
    [4,4, 5,3,1,6],
    [9,2, 2,1,9,3]]))
