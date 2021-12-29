# Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
# A subarray is a contiguous part of an array.

# 1 <= nums.length <= 10^5
# -10^4 <= nums[i] <= 10^4
from typing import List

class Solution:
    def maxSubArray(self, nums: List[int]) -> int:
        sum, max = 0, nums[0]
        for num in nums:
            sum += num
            if sum > max:
                max = sum
            if sum<0:
                sum = 0
                continue
        return max

solver = Solution()
print(solver.maxSubArray([8,-19,5,-4,20])) # 21, [-1]
print(solver.maxSubArray([-2,-1])) # -1, [-1]
print(solver.maxSubArray([-1])) # -1, [-1]
print(solver.maxSubArray([-2,1,-3,4,-1,2,1,-5,4])) # 6, [4,-1,2,1]
print(solver.maxSubArray([1])) # 1, [1]
print(solver.maxSubArray([5,4,-1,7,8])) # 23, [5,4,-1,7,8]