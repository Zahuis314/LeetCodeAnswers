from typing import List

# Given an integer array nums and an integer k, return the kth largest element in the array.
# Note that it is the kth largest element in the sorted order, not the kth distinct element.
# You must solve it in O(n) time complexity.

# 1 <= k <= nums.length <= 10^5
# -10^4 <= nums[i] <= 10^4

class Solution:
    def findKthLargest(self, nums: List[int], k: int) -> int:
        return sorted(nums)[-k]

solver = Solution()
print(solver.findKthLargest([3,2,1,5,6,4],2)==5)
print(solver.findKthLargest([3,2,3,1,2,4,5,5,6],4)==4)