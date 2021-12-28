# Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
# Note that you must do this in-place without making a copy of the array.

# 1 <= nums.length <= 10^4
# -2^31 <= nums[i] <= 2^31 - 1

from typing import List

class Solution:
    def moveZeroes(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        inserting_point, searching_point = 0,0
        while inserting_point != len(nums):
            if searching_point == len(nums):
                nums[inserting_point] = 0
                inserting_point += 1
            elif nums[searching_point] == 0:
                searching_point +=1
            else:
                nums[inserting_point] = nums[searching_point]
                inserting_point += 1
                searching_point +=1
    def moveZeroesOptimal(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        inserting_point, searching_point = 0,0
        while searching_point < len(nums):
            if nums[searching_point] != 0:
                nums[inserting_point], nums[searching_point] = nums[searching_point], nums[inserting_point]
                inserting_point += 1
            searching_point +=1


solver = Solution()
l=[0,1,0,3,12]
result = solver.moveZeroes(l)
print(l) #[1,3,12,0,0]

l=[0]
result = solver.moveZeroes(l)
print(l) #[0]