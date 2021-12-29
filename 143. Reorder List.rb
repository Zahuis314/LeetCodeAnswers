# You are given the head of a singly linked-list. The list can be represented as:

# L0 → L1 → … → Ln - 1 → Ln
# Reorder the list to be on the following form:

# L0 → Ln → L1 → Ln - 1 → L2 → Ln - 2 → …
# You may not modify the values in the list's nodes. Only nodes themselves may be changed.

require "./utils.rb"

# Definition for singly-linked list.
# class ListNode
#     attr_accessor :val, :next
#     def initialize(val = 0, _next = nil)
#         @val = val
#         @next = _next
#     end
# end
# @param {ListNode} head
# @return {Void} Do not return anything, modify head in-place instead.
def reorder_list(head)
    temp_list = []
    temp_head = head
    while temp_head
        temp_list << temp_head
        temp_head = temp_head.next
    end
    temp_head = head
    while temp_list.first
        first = temp_list.shift
        first.next = temp_list.pop
        first.next.next = temp_list.first if first.next
    end
end

def reorder_list_without_modifications(head)
    temp_list = []
    temp_head = head
    while temp_head
        temp_list << temp_head
        temp_head = temp_head.next
    end
    (temp_list.length/2).times do |i|
        temp_list[i].next = temp_list[-(i+1)]
        temp_list[-(i+1)].next = temp_list[i+1]
    end
    temp_list[temp_list.length/2].next = nil
end

r1 = Node.new(1)
r2 = Node.new(2)
r3 = Node.new(3)
r4 = Node.new(4)
r5 = Node.new(5)

r1.next = r2
# r2.next = r3
# r3.next = r4
# r4.next = r5

reorder_list(r1)
p 1