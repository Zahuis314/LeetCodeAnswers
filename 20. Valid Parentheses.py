# Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
# An input string is valid if:
# Open brackets must be closed by the same type of brackets.
# Open brackets must be closed in the correct order.

# 1 <= s.length <= 10^4
# s consists of parentheses only '()[]{}'.

class Solution:
    def isValid(self, s: str) -> bool:
        stack = []
        opposite = {"}": "{","]": "[", ")": "("}
        for char in s:
            if char == "{" or char == "(" or char == "[":
                stack.append(char)
            else:
                if len(stack)==0:
                    return False
                top = stack.pop()
                if opposite[char] != top:
                    return False
        return len(stack)==0

solver = Solution()
print(solver.isValid("()")) # True
print(solver.isValid("()[]{}")) # True
print(solver.isValid("(]")) # False
print(solver.isValid("{{}[][[[]]]}")) # True
print(solver.isValid("{{({})}}")) # True