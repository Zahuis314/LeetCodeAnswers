# You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security systems connected and it will automatically contact the police if two adjacent houses were broken into on the same night.
# Given an integer array nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police.

# 1 <= nums.length <= 100
# 0 <= nums[i] <= 400

from typing import List
from functools import *

class Solution:
    def rob(self, nums: List[int]) -> int:
        @lru_cache(None)
        def dp(index: int) -> int:
            if index>=len(nums):
                return 0
            return max(nums[index]+dp(index+2),dp(index+1))
        return dp(0)

solver = Solution()
print(solver.rob([1,2,3,1])==4)
print(solver.rob([2,7,9,3,1])==12)
print(solver.rob([1])==1)
print(solver.rob([1,2])==2)
print(solver.rob([183,219,57,193,94,233,202,154,65,240,97,234,100,249,186,66,90,238,168,128,177,235,50,81,185,165,217,207,88,80,112,78,135,62,228,247,211])==3365)
