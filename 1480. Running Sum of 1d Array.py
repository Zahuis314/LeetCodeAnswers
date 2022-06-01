# Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
# Return the running sum of nums.

# 1 <= nums.length <= 1000
# -10^6 <= nums[i] <= 10^6
from typing import List

class Solution:
    def runningSum(self, nums: List[int]) -> List[int]:
        for i in range(1,len(nums)):
            nums[i]=nums[i-1]+nums[i]
        return nums

solver = Solution()
print(solver.runningSum([1,2,3,4])) #[1,3,6,10]
print(solver.runningSum([1,1,1,1,1])) #[1,2,3,4,5]
print(solver.runningSum([3,1,2,10,1])) #[3,4,6,16,17]