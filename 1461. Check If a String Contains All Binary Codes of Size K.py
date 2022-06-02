# Given a binary string s and an integer k, return true if every binary code of length k is a substring of s. Otherwise, return false.

# 1 <= s.length <= 5 * 10^5
# s[i] is either '0' or '1'.
# 1 <= k <= 20

class Solution(object):
    def hasAllCodes(self, s, k):
        """
        :type s: str
        :type k: int
        :rtype: bool
        """
        actuals = set()
        for i in range(len(s)-k+1):
            actuals.add(s[i:i+k])
        return len(actuals)==2**k

solver = Solution()
print(solver.hasAllCodes("00110110", 2))    # true
print(solver.hasAllCodes("0110", 1))    # true
print(solver.hasAllCodes("0110", 2))    # false