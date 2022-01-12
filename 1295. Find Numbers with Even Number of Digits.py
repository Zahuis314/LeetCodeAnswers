# Given an array nums of integers, return how many of them contain an even number of digits.

# 1 <= nums.length <= 500
# 1 <= nums[i] <= 10^5

from typing import List


class Solution:
    def findNumbers(self, nums: List[int]) -> int:
        return len(list(filter(lambda n_length: n_length%2 ==0, map(lambda x:len(str(x)),nums))))