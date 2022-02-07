# Given an integer array nums that may contain duplicates, return all possible subsets (the power set).
# The solution set must not contain duplicate subsets. Return the solution in any order.

# 1 <= nums.length <= 10
# -10 <= nums[i] <= 10

from typing import List


class Solution:
    def subsetsWithDup(self, nums: List[int]) -> List[List[int]]:
        result = set()
        nums.sort()
        def recursion(index: int, current: List[int]):
            if index == len(nums):
                result.add(tuple(current))
            else:
                recursion(index+1,current+[nums[index]])
                recursion(index+1,current)
        recursion(0,[])
        return [list(x) for x in result]
        

solver = Solution()
print(solver.subsetsWithDup([1]))
print(solver.subsetsWithDup([1,2,2]))
print(solver.subsetsWithDup([1,2,3]))
print(solver.subsetsWithDup([4,4,4,1,4]))
#[[],[1],[1,4],[1,4,4],[1,4,4,4],[1,4,4,4,4],[4],[4,4],[4,4,4],[4,4,4,4]]