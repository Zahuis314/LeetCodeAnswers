# You are assigned to put some amount of boxes onto one truck. You are given a 2D array boxTypes, where boxTypes[i] = [numberOfBoxesi, numberOfUnitsPerBoxi]:
# numberOfBoxesi is the number of boxes of type i.
# numberOfUnitsPerBoxi is the number of units in each box of the type i.
# You are also given an integer truckSize, which is the maximum number of boxes that can be put on the truck. You can choose any boxes to put on the truck as long as the number of boxes does not exceed truckSize.
# Return the maximum total number of units that can be put on the truck.

# 1 <= boxTypes.length <= 1000
# 1 <= numberOfBoxesi, numberOfUnitsPerBoxi <= 1000
# 1 <= truckSize <= 10^6

from typing import List


class Solution:
    def maximumUnits(self, boxTypes: List[List[int]], truckSize: int) -> int:
        boxTypes.sort(key=lambda x: (-x[1], x[0]))
        result = 0
        remaining = truckSize
        for (numberOfBoxes, unitPerBoxes) in boxTypes:
            if remaining > numberOfBoxes:
                remaining -= numberOfBoxes
                result += numberOfBoxes*unitPerBoxes
            else:
                result += remaining*unitPerBoxes
                return result
        return result
    
solver = Solution()
print(solver.maximumUnits(boxTypes = [[1,3],[2,2],[3,1]], truckSize = 4)==8)
print(solver.maximumUnits(boxTypes = [[5,10],[2,5],[4,7],[3,9]], truckSize = 10)==91)