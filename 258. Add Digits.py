# Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.

# 0 <= num <= 2^31 - 1

class Solution:
    def addDigits(self, num: int) -> int:
        while num>9:
            next_number = 0
            while num != 0:
                next_number += num%10
                num //= 10
            num = next_number
        return num
        # return 1 + (num - 1) % 9 if num else 0
        
solver = Solution()
print(solver.addDigits(38)==2)
print(solver.addDigits(0)==0)
print(solver.addDigits(9)==9)
print(solver.addDigits(11)==2)
print(solver.addDigits(9999)==9)