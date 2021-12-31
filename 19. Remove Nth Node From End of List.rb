# Given the head of a linked list, remove the nth node from the end of the list and return its head.

# The number of nodes in the list is sz.
# 1 <= sz <= 30
# 0 <= Node.val <= 100
# 1 <= n <= sz
 
require "./utils.rb"

# @param {ListNode} head
# @param {Integer} n
# @return {ListNode}
def remove_nth_from_end(head, n)
    dummy = ListNode.new(-1)
    dummy.next = head
    slow, fast = dummy, dummy
    n.times {fast=fast.next}
    while fast.next do
        slow, fast = slow.next, fast.next
    end
    slow.next = slow.next.next
    dummy.next
end

n5 = ListNode.new(5)
n4 = ListNode.new(4,n5)
n3 = ListNode.new(3,n4)
n2 = ListNode.new(2,n3)
n1 = ListNode.new(1,n2)
result = remove_nth_from_end(n1,2) # 4

n2 = ListNode.new(2)
n1 = ListNode.new(1,n2)
result = remove_nth_from_end(n1,1)
p 1