# Given a positive integer k, you need to find the length of the smallest positive integer n such that n is divisible by k, and n only contains the digit 1.
# Return the length of n. If there is no such n, return -1.
# Note: n may not fit in a 64-bit signed integer.

# 1 <= k <= 10^5

class Solution:
    def smallestRepunitDivByK(self, k: int) -> int:
        if k % 2 == 0 or k % 5 == 0:
            return -1
        remain = 0
        for c in range(1, k+1):
            remain = (remain*10 + 1)%k
            if remain == 0: return c
        return -1

solver = Solution()
print(solver.smallestRepunitDivByK(1)) # 1
print(solver.smallestRepunitDivByK(2)) # -1
print(solver.smallestRepunitDivByK(3)) # 3
print(solver.smallestRepunitDivByK(7)) # 6
print(solver.smallestRepunitDivByK(13)) # 6
print(solver.smallestRepunitDivByK(17)) # 16
print(solver.smallestRepunitDivByK(19)) # 18
print(solver.smallestRepunitDivByK(23)) # 22
print(solver.smallestRepunitDivByK(29)) # 28