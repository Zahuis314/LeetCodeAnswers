# Given an integer array nums of size n, return the minimum number of moves required to make all array elements equal.
# In one move, you can increment or decrement an element of the array by 1.
# Test cases are designed so that the answer will fit in a 32-bit integer.

# n == nums.length
# 1 <= nums.length <= 10^5
# -10^9 <= nums[i] <= 10^9

from typing import List


class Solution:
    def minMoves2(self, nums: List[int]) -> int:
        nums.sort()
        result = 0
        for num in nums:
            result += abs(num-nums[int(len(nums)/2)]) 
        return result

solver = Solution()
print(solver.minMoves2([1,2,3])==2)
print(solver.minMoves2([1,10,2,9])==16)