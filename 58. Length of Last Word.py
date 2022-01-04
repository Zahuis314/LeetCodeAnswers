# Given a string s consisting of some words separated by some number of spaces, return the length of the last word in the string.
# A word is a maximal substring consisting of non-space characters only.

# 1 <= s.length <= 10^4
# s consists of only English letters and spaces ' '.
# There will be at least one word in s.

class Solution:
    def lengthOfLastWord(self, s: str) -> int:
        words = s.split()
        return len(words[-1])

solver = Solution()
print(solver.lengthOfLastWord("Hello World")) # 5
print(solver.lengthOfLastWord("   fly me   to   the moon  ")) # 4
print(solver.lengthOfLastWord("luffy is still joyboy")) # 6