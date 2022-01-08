# You are given two binary trees root1 and root2.
# Imagine that when you put one of them to cover the other, some nodes of the two trees are overlapped while the others are not. You need to merge the two trees into a new binary tree. The merge rule is that if two nodes overlap, then sum node values up as the new value of the merged node. Otherwise, the NOT null node will be used as the node of the new tree.
# Return the merged tree.
# Note: The merging process must start from the root nodes of both trees.


# The number of nodes in both trees is in the range [0, 2000].
# -10^4 <= Node.val <= 10^4
require "./utils.rb"

# @param {TreeNode} root1
# @param {TreeNode} root2
# @return {TreeNode}
def merge_trees(root1, root2)
    return root2 if root1.nil?
    return root1 if root2.nil?
    TreeNode.new(root1.val + root2.val,
        merge_trees(root1.left, root2.left),
        merge_trees(root1.right, root2.right)
    )
end

l5 = TreeNode.new(5);
l3 = TreeNode.new(3,l5);
l2 = TreeNode.new(2);
l1 = TreeNode.new(1,l3,l2);

r4 = TreeNode.new(4);
r1 = TreeNode.new(1,nil,r4);
r7 = TreeNode.new(7);
r3 = TreeNode.new(3,nil,r7);
r2 = TreeNode.new(2,r1,r3);
result = merge_trees(l1,r2)

r1 = TreeNode.new(1)
l2 = TreeNode.new(2)
l1 = TreeNode.new(1,l2)
result = merge_trees(l1,r1)