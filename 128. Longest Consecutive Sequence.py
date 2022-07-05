# Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.
# You must write an algorithm that runs in O(n) time.

# 0 <= nums.length <= 10^5
# -10^9 <= nums[i] <= 10^9

from typing import List


class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        if len(nums)<=1:
            return len(nums)
        nums.sort()
        maxx=1
        current=1
        for index in range(len(nums)-1):
            if(nums[index+1]==nums[index]):
                pass
            elif(nums[index+1]==nums[index]+1):
                current+=1
                maxx=max(maxx,current)
            else:
                current = 1
        return maxx

solver = Solution()
print(solver.longestConsecutive([100,4,200,1,3,2])==4)
print(solver.longestConsecutive([0,3,7,2,5,8,4,6,0,1])==9)