# You are given the root node of a binary search tree (BST) and a value to insert into the tree. Return the root node of the BST after the insertion. It is guaranteed that the new value does not exist in the original BST.
# Notice that there may exist multiple valid ways for the insertion, as long as the tree remains a BST after insertion. You can return any of them.

# The number of nodes in the tree will be in the range [0, 10^4].
# -10^8 <= Node.val <= 10^8
# All the values Node.val are unique.
# -10^8 <= val <= 10^8
# It's guaranteed that val does not exist in the original BST.

from typing import Optional
from utils import *

class Solution:
    def insertIntoBST(self, root: Optional[TreeNode], val: int) -> Optional[TreeNode]:
        if root == None:
            return TreeNode(val)
        if val < root.val:
            root.left = self.insertIntoBST(root.left,val)
        else:
            root.right = self.insertIntoBST(root.right,val)
        return root

solver = Solution()

t1_1 = TreeNode(1)
t1_3 = TreeNode(3)
t1_7 = TreeNode(7)
t1_2 = TreeNode(2, t1_1, t1_3)
t1_4 = TreeNode(4, t1_2, t1_7)
test1 = solver.insertIntoBST(t1_4, 5)

t2_10 = TreeNode(10)
t2_30 = TreeNode(30)
t2_20 = TreeNode(20, t2_10, t2_30)
t2_50 = TreeNode(50)
t2_70 = TreeNode(70)
t2_60 = TreeNode(60, t2_50, t2_70)
t2_40 = TreeNode(40, t2_20, t2_60)
test2 = solver.insertIntoBST(t2_40, 25)

t3_3 = TreeNode(3)
t3_1 = TreeNode(1)
t3_2 = TreeNode(2, t3_1, t3_3)
t3_7 = TreeNode(7)
t3_4 = TreeNode(4, t3_2, t3_7)
test3 = solver.insertIntoBST(t3_4, 5)
print("ya")