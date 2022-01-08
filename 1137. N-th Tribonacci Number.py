# The Tribonacci sequence Tn is defined as follows: 
# T0 = 0, T1 = 1, T2 = 1, and Tn+3 = Tn + Tn+1 + Tn+2 for n >= 0.
# Given n, return the value of Tn.

# 0 <= n <= 37
# The answer is guaranteed to fit within a 32-bit integer, ie. answer <= 2^31 - 1.


class Solution:
    def tribonacci(self, n: int) -> int:
        if n==0:
            return 0
        p, pp, ppp = 0, 1, 1
        for _ in range(n-2):
            p, pp, ppp = pp, ppp, p+pp+ppp
        return ppp

solver = Solution()
print(solver.tribonacci(0))
print(solver.tribonacci(1))
print(solver.tribonacci(2))
print(solver.tribonacci(3))
print(solver.tribonacci(4)==4)
print(solver.tribonacci(25)==1389537)