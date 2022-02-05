# You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.
# Merge all the linked-lists into one sorted linked-list and return it.

# k == lists.length
# 0 <= k <= 10^4
# 0 <= lists[i].length <= 500
# -10^4 <= lists[i][j] <= 10^4
# lists[i] is sorted in ascending order.
# The sum of lists[i].length won't exceed 10^4.

require './utils.rb'

# @param {ListNode[]} lists
# @return {ListNode}
def merge_k_lists(lists)
    return lists[0] if lists.length <= 1
    middle = lists.length/2
    merge(merge_k_lists(lists[...middle]),merge_k_lists(lists[middle..]))
end

def merge(list1,list2)
    return list2 if list1.nil?
    return list1 if list2.nil?
    if list1.val<=list2.val
        list1.next = merge(list1.next,list2)
        return list1
    else
        list2.next = merge(list1,list2.next)
        return list2
    end
end

result = merge_k_lists([
    convert_to_list_node([1,4,5]),
    convert_to_list_node([1,3,4]),
    convert_to_list_node([2,6])
])
result = merge_k_lists([])
result = merge_k_lists([nil])
result = merge_k_lists([nil,nil])
p result