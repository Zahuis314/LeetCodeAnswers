# Given two integer arrays preorder and inorder where preorder is the preorder traversal of a binary tree and inorder is the inorder traversal of the same tree, construct and return the binary tree.

# 1 <= preorder.length <= 3000
# inorder.length == preorder.length
# -3000 <= preorder[i], inorder[i] <= 3000
# preorder and inorder consist of unique values.
# Each value of inorder also appears in preorder.
# preorder is guaranteed to be the preorder traversal of the tree.
# inorder is guaranteed to be the inorder traversal of the tree.

from typing import List, Optional
from utils import *

class Solution:
    def buildTree(self, preorder: List[int], inorder: List[int]) -> Optional[TreeNode]:
        if(len(preorder)==0):
            return None
        val = preorder[0]
        left_end = inorder.index(val)
        left_preorder = preorder[1:left_end+1]
        right_preorder = preorder[left_end+1:]

        left_inorder = inorder[:left_end]
        right_inorder = inorder[left_end+1:]
        return TreeNode(val, self.buildTree(left_preorder,left_inorder),self.buildTree(right_preorder,right_inorder))

solver = Solution()
solver.buildTree(preorder = [3,9,20,15,7], inorder = [9,3,15,20,7])

#s1 =   3
#    9    20
#        15 7 

solver.buildTree(preorder = [-1], inorder = [-1])   # -1
