# Given a triangle array, return the minimum path sum from top to bottom.
# For each step, you may move to an adjacent number of the row below. More formally, if you are on index i on the current row, you may move to either index i or index i + 1 on the next row. 

# 1 <= triangle.length <= 200
# triangle[0].length == 1
# triangle[i].length == triangle[i - 1].length + 1
# -10^4 <= triangle[i][j] <= 10^4

from typing import List
from functools import *


class Solution:
    def minimumTotal(self, triangle: List[List[int]]) -> int:
        height = len(triangle)
        @lru_cache(None)
        def dp(x: int, y: int) -> int:
            if x == height-1:
                return triangle[x][y]
            return triangle[x][y] + min(dp(x+1, y), dp(x+1, y+1))
        return dp(0,0)

solver = Solution()
print(solver.minimumTotal([
    [2],
    [3,4],
    [6,5,7],
    [4,1,8,3]]
    )==11)
print(solver.minimumTotal([[-10]])==-10)