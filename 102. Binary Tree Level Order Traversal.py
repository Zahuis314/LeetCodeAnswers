# Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).

# The number of nodes in the tree is in the range [0, 2000].
# -1000 <= Node.val <= 1000

from typing import List, Optional
from utils import *

class Solution:
    def levelOrder(self, root: Optional[TreeNode]) -> List[List[int]]:
        if(root == None):
            return []
        queue = [root]
        result=[]
        while len(queue)!=0:
            row = []
            for _ in range(len(queue)):
                current = queue.pop(0)
                if current.left !=None:
                    queue.append(current.left)
                if current.right !=None:
                    queue.append(current.right)
                row.append(current.val)
            result.append(row)
            
        return result

solver = Solution()
t1 = TreeNode(3,
        TreeNode(9),
        TreeNode(20,
            TreeNode(15),
            TreeNode(7)))
solver.levelOrder(t1)   #[[3],[9,20],[15,7]]

solver.levelOrder(TreeNode(1))  #[[1]]
solver.levelOrder(None)  #[[]]