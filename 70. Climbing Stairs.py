# You are climbing a staircase. It takes n steps to reach the top.
# Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

# 1 <= n <= 45

class Solution:
    def climbStairs(self, n: int) -> int:
        p, pp = 0, 1
        for _ in range(n):
            p, pp = pp, p + pp
        return pp
    

solver = Solution()
print(solver.climbStairs(2)==2)
print(solver.climbStairs(3)==3)
print(solver.climbStairs(4)==5)
print(solver.climbStairs(5)==8)
print(solver.climbStairs(6)==13)