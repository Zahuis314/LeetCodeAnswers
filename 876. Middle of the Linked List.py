# Given the head of a singly linked list, return the middle node of the linked list.
# If there are two middle nodes, return the second middle node.

# The number of nodes in the list is in the range [1, 100].
# 1 <= Node.val <= 100

from typing import Optional
from utils import *

class Solution:
    def middleNode(self, head: Optional[ListNode]) -> Optional[ListNode]:
        result = head
        alternate = False
        
        while(True):
            if alternate:
                result = result.next
            alternate = not alternate
            head = head.next
            if head is None:
                break
        return result

    def middleNode_without_altarnate(self, head: Optional[ListNode]) -> Optional[ListNode]:
        result, lookup = head, head
        while lookup and lookup.next:
            result, lookup = result.next, lookup.next.next
        return result

solver = Solution()
result = solver.middleNode(convert_to_list_node([1,2,3,4,5]))
print(result) #[3,4,5]

result = solver.middleNode(convert_to_list_node([1,2,3,4,5,6]))
print(result) #[4,5,6]