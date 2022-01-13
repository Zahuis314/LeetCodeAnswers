# There are some spherical balloons taped onto a flat wall that represents the XY-plane. The balloons are represented as a 2D integer array points where points[i] = [xstart, xend] denotes a balloon whose horizontal diameter stretches between xstart and xend. You do not know the exact y-coordinates of the balloons.
# Arrows can be shot up directly vertically (in the positive y-direction) from different points along the x-axis. A balloon with xstart and xend is burst by an arrow shot at x if xstart <= x <= xend. There is no limit to the number of arrows that can be shot. A shot arrow keeps traveling up infinitely, bursting any balloons in its path.
# Given the array points, return the minimum number of arrows that must be shot to burst all balloons.

# 1 <= points.length <= 10^5
# points[i].length == 2
# -2^31 <= xstart < xend <= 2^31 - 1

from typing import List


class Solution:
    def findMinArrowShots(self, points: List[List[int]]) -> int:
        points.sort(
          key=lambda x: (x[1],x[0])
        )
        result=0
        while len(points) > 0:
            head = points.pop(0)
            while len(points) > 0 and points[0][0]<=head[1]:
                points.pop(0)
            result+=1
        return result


solver = Solution()
print(solver.findMinArrowShots([[10,12],[2,8],[1,6],[7,12]])==2)
print(solver.findMinArrowShots([[10,16],[2,8],[1,6],[7,12]])==2)
print(solver.findMinArrowShots([[1,2],[3,4],[5,6],[7,8]])==4)
print(solver.findMinArrowShots([[1,2],[2,3],[3,4],[4,5]])==2)