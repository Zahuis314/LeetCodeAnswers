# Given a string s, you can transform every letter individually to be lowercase or uppercase to create another string.
# Return a list of all possible strings we could create. Return the output in any order.

# 1 <= s.length <= 12
# s consists of lowercase English letters, uppercase English letters, and digits.

from typing import List


class Solution:
    def letterCasePermutation(self, s: str) -> List[str]:
        result = []
        def recursiveLetterCasePermutation(s:str ,current: str):
            if len(s) == 1:
                if s.isalpha():
                    result.append(current+s.lower())
                    result.append(current+s.upper())
                else:
                    result.append(current+s)
            else:
                if s[0].isalpha():
                    recursiveLetterCasePermutation(s[1:],current+s[0].lower())
                    recursiveLetterCasePermutation(s[1:],current+s[0].upper())
                else:
                    recursiveLetterCasePermutation(s[1:],current+s[0])
        recursiveLetterCasePermutation(s,'')
        return result

solver = Solution()
print(solver.letterCasePermutation("a1b2"))
print(solver.letterCasePermutation("3z4"))
print(solver.letterCasePermutation("C"))