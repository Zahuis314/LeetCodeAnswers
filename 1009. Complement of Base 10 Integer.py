# The complement of an integer is the integer you get when you flip all the 0's to 1's and all the 1's to 0's in its binary representation.
# For example, The integer 5 is "101" in binary and its complement is "010" which is the integer 2.
# Given an integer n, return its complement.

# 0 <= n < 10^9

class Solution:
    def bitwiseComplement(self, n: int) -> int:
        mask = max(2 ** n.bit_length() - 1,1)
        complement = n ^ mask
        return complement

solver = Solution()
print(solver.bitwiseComplement(0)) # 1
print(solver.bitwiseComplement(5)) # 2
print(solver.bitwiseComplement(7)) # 0
print(solver.bitwiseComplement(10)) # 5