# Definition for a binary tree node.
class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right

# Definition for singly-linked list.
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
    def __str__(self):
        return str(self.__repr__())

    def __repr__(self):
        current = [self.val]
        if self.next:
            current.extend(self.next.__repr__())
        return current

def convert_to_list_node(arr):
    if len(arr) == 1:
        return ListNode(arr[0])
    return ListNode(arr[0],convert_to_list_node(arr[1:]))