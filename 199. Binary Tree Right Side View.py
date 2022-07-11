# Given the root of a binary tree, imagine yourself standing on the right side of it, return the values of the nodes you can see ordered from top to bottom.

# The number of nodes in the tree is in the range [0, 100].
# -100 <= Node.val <= 100

from tkinter.messagebox import NO
from typing import List, Optional
from utils import *

class Solution:
    def rightSideView(self, root: Optional[TreeNode]) -> List[int]:
        if(root == None):
            return []
        queue = [(root,0)]
        result=[]
        while len(queue)!=0:
            current = queue.pop(0)
            if current[0].left !=None:
                queue.append((current[0].left,current[1]+1))
            if current[0].right !=None:
                queue.append((current[0].right,current[1]+1))
            if len(result)>current[1]:
                result[current[1]] = current[0].val
            else:
                result.append(current[0].val)
            
        return result

solver = Solution()
t1 = TreeNode(1,
        TreeNode(2,
            None,
            TreeNode(5)),
        TreeNode(3,
            None,
            TreeNode(4)))
solver.rightSideView(t1)    #[1,3,4]

t2 = TreeNode(1,None,TreeNode(3))
solver.rightSideView(t2)    #[1,3]

solver.rightSideView(None)    #[]