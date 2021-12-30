# Write a function that reverses a string. The input string is given as an array of characters s.
# You must do this by modifying the input array in-place with O(1) extra memory.

# 1 <= s.length <= 10^5
# s[i] is a printable ascii character.

from typing import List

class Solution:
    def reverseString(self, s: List[str]) -> None:
        """
        Do not return anything, modify s in-place instead.
        """
        for i in range(len(s)//2):
            s[i],s[-i-1] = s[-i-1],s[i]
        # s.reverse()
        

solver = Solution()
test = ["h","e","l","l","o"]
solver.reverseString(test)
print(test) # ["o","l","l","e","h"]

test1 = ["H","a","n","n","a","h"]
solver.reverseString(test1)
print(test1) # ["h","a","n","n","a","H"]
print(1)