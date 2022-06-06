# Given the heads of two singly linked-lists headA and headB, return the node at which the two lists intersect. If the two linked lists have no intersection at all, return null.
# The test cases are generated such that there are no cycles anywhere in the entire linked structure.
# Note that the linked lists must retain their original structure after the function returns.
# Custom Judge:
# The inputs to the judge are given as follows (your program is not given these inputs):
# intersectVal - The value of the node where the intersection occurs. This is 0 if there is no intersected node.
# listA - The first linked list.
# listB - The second linked list.
# skipA - The number of nodes to skip ahead in listA (starting from the head) to get to the intersected node.
# skipB - The number of nodes to skip ahead in listB (starting from the head) to get to the intersected node.
# The judge will then create the linked structure based on these inputs and pass the two heads, headA and headB to your program. If you correctly return the intersected node, then your solution will be accepted.

# The number of nodes of listA is in the m.
# The number of nodes of listB is in the n.
# 1 <= m, n <= 3 * 10^4
# 1 <= Node.val <= 10^5
# 0 <= skipA < m
# 0 <= skipB < n
# intersectVal is 0 if listA and listB do not intersect.
# intersectVal == listA[skipA] == listB[skipB] if listA and listB intersect.

from typing import Optional
from utils import ListNode, convert_to_list_node


class Solution:
    def getIntersectionNode(self, headA: ListNode, headB: ListNode) -> Optional[ListNode]:
        current_a = headA
        current_b = headB
        while current_a!=current_b:
            if current_a == None:
                current_a = headB
            else:
                current_a = current_a.next
            if current_b == None:
                current_b = headA
            else:
                current_b = current_b.next
        return current_a

solver = Solution()
solver.getIntersectionNode(convert_to_list_node([4,1,8,4,5]),convert_to_list_node([5,6,1,8,4,5]))   # [8,4,5]
solver.getIntersectionNode(convert_to_list_node([1,9,1,2,4]),convert_to_list_node([3,2,4]))   # [2,4]
solver.getIntersectionNode(convert_to_list_node([2,6,4]),convert_to_list_node([1,5]))   # null