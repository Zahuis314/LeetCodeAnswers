# You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
# You may assume the two numbers do not contain any leading zero, except the number 0 itself.

# The number of nodes in each linked list is in the range [1, 100].
# 0 <= Node.val <= 9
# It is guaranteed that the list represents a number that does not have leading zeros.

from typing import  Optional
from utils import *

class Solution:
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
        result = ListNode(0)
        current = result
        carry = 0
        while l1 or l2:
            current.next = ListNode()
            current = current.next
            sum = carry
            if l1:
                sum += l1.val
                l1 = l1.next
            if l2:
                sum += l2.val
                l2 = l2.next
            current.val = sum % 10
            carry = 1 if sum > 9 else 0
        if carry:
            current.next = ListNode(1)
        return result.next        

solver = Solution()
result = solver.addTwoNumbers(convert_to_list_node([2,4,3]), convert_to_list_node([5,6,4]))
print(result) #[7,0,8]

result = solver.addTwoNumbers(convert_to_list_node([0]), convert_to_list_node([0]))
print(result) #[0]

result = solver.addTwoNumbers(convert_to_list_node([9,9,9,9,9,9,9]), convert_to_list_node([9,9,9,9]))
print(result) #[8,9,9,9,0,0,0,1]