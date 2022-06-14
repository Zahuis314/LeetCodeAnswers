# Given two strings word1 and word2, return the minimum number of steps required to make word1 and word2 the same.
# In one step, you can delete exactly one character in either string.

# 1 <= word1.length, word2.length <= 500
# word1 and word2 consist of only lowercase English letters.

class Solution:
    def minDistance(self, word1: str, word2: str) -> int:
        dp = [[0]*(len(word2)+1) for _ in range(len(word1)+1)]
        for i in range(len(dp)):
            for j in range(len(dp[i])):
                if i*j==0:
                    dp[i][j]=i+j
                elif word1[i-1]==word2[j-1]:
                    dp[i][j]=dp[i-1][j-1]
                else:
                    dp[i][j]=1+min(dp[i-1][j],dp[i][j-1])
        return dp[-1][-1]

solver = Solution()
print(solver.minDistance(word1 = "sea", word2 = "eat")==2)
print(solver.minDistance(word1 = "leetcode", word2 = "etco")==4)
