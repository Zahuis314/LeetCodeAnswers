# Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.

# 1 <= nums.length <= 10^4
# -10^4 <= nums[i] <= 10^4
# nums is sorted in non-decreasing order.

from typing import List

class Solution:
    def searchZero(self, nums: List[int]) -> int:
        left = 0
        right = len(nums)-1
        while left <= right:
            middle = (left+right)//2
            if nums[middle] == 0:
                return middle
            elif nums[middle] < 0:
                left = middle + 1
            else:
                right = middle - 1
        return left

    def sortedSquares(self, nums: List[int]) -> List[int]:
        zeroPos = self.searchZero(nums)
        i = zeroPos - 1
        j = i + 1
        result = []
        while (i >= 0 or j<len(nums)):
            if j==len(nums) or (i >= 0 and abs(nums[i]) < nums[j]):
                result.append(nums[i]**2)
                i-=1
            else:
                result.append(nums[j]**2)
                j+=1
        return result

solver = Solution()
result = solver.sortedSquares([-4,-1,0,3,10])
print(result) #[0,1,9,16,100]

result = solver.sortedSquares([-11,-4,-1,0,3,10])
print(result) #[0,1,9,16,100,121]

result = solver.sortedSquares([-7,-3,2,3,11])
print(result) #[4,9,9,49,121]

result = solver.sortedSquares([-15,-7,-3,2,3,11])
print(result) #[4,9,9,49,121,225]