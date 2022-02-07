# Given an integer array nums of unique elements, return all possible subsets (the power set).
# The solution set must not contain duplicate subsets. Return the solution in any order.

# 1 <= nums.length <= 10
# -10 <= nums[i] <= 10
# All the numbers of nums are unique.

from typing import List

class Solution:
    def subsets(self, nums: List[int]) -> List[List[int]]:
        result = []
        def recursion(index: int, current: List[int]):
            if index == len(nums):
                result.append(current)
            else:
                recursion(index+1,current+[nums[index]])
                recursion(index+1,current)
        recursion(0,[])
        return result
        

solver = Solution()
print(solver.subsets([1]))
print(solver.subsets([1,2,3]))