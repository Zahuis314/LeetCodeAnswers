# Given the head of a singly linked list, reverse the list, and return the reversed list.

# The number of nodes in the list is the range [0, 5000].
# -5000 <= Node.val <= 5000

require "./utils.rb"
# @param {ListNode} head
# @return {ListNode}
def reverse_list(head)
    return nil if head.nil?
    reverse_list_rec(head,nil)
end

def reverse_list_rec(head,previous)
    temp = head.next
    head.next = previous
    return head if temp.nil?
    reverse_list_rec(temp,head)
end

n5 = ListNode.new(5)
n4 = ListNode.new(4,n5)
n3 = ListNode.new(3,n4)
n2 = ListNode.new(2,n3)
n1 = ListNode.new(1,n2)
r = reverse_list(n5)