# Given a string s, return the longest palindromic substring in s.

# 1 <= s.length <= 1000
# s consist of only digits and English letters.

class Solution:
    def longestPalindrome(self, s: str) -> str:
        def longestAtIndex(s, left, rigth):
            while left >= 0 and rigth < len(s) and s[left] == s[rigth]:
                left -= 1
                rigth += 1
            left += 1
            rigth -= 1
            return (rigth - left + 1, left, rigth)
        longest = 0
        begin = 0
        end = -1
        for i in range(len(s)):
            for j in range(2):
                length, l, r = longestAtIndex(s, i, i + j)
                if length > longest:
                    longest = length
                    begin = l
                    end = r
        return s[begin:end+1]

solver = Solution()
print(solver.longestPalindrome("babad") == "bab")
print(solver.longestPalindrome("bababsbscss"))
print(solver.longestPalindrome("cbbd") == "bb")
print(solver.longestPalindrome("a") == "a")
print(solver.longestPalindrome("ab")=="a")
print(solver.longestPalindrome("abc")=="a")