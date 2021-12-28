# Given an array, rotate the array to the right by k steps, where k is non-negative.

# 1 <= nums.length <= 10^5
# -2^31 <= nums[i] <= 2^31 - 1
# 0 <= k <= 10^5


from typing import List

class Solution:
    def rotate_removing(self, nums: List[int], k: int) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        k = (-k) % len(nums)
        for _ in range(k):
            nums.append(nums.pop(0))
        print(nums)

    def _reverse(self, nums, i, j):
        while i < j:
            nums[i], nums[j - 1] = nums[j - 1], nums[i]
            i += 1
            j -= 1

    def rotate_reversing(self, nums: List[int], k: int) -> None:
        k %= len(nums)
        self._reverse(nums, 0, len(nums))
        self._reverse(nums, 0, k)
        self._reverse(nums, k, len(nums))



solver = Solution()
l=[1,2,3,4,5,6,7]
result = solver.rotate_reversing(l,3)
print(l) #[5,6,7,1,2,3,4]

l=[-1,-100,3,99]
result = solver.rotate_reversing(l,2)
print(l) #[3,99,-1,-100]