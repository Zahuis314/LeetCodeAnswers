# You are given the root of a binary tree where each node has a value 0 or 1. Each root-to-leaf path represents a binary number starting with the most significant bit.
# For example, if the path is 0 -> 1 -> 1 -> 0 -> 1, then this could represent 01101 in binary, which is 13.
# For all leaves in the tree, consider the numbers represented by the path from the root to that leaf. Return the sum of these numbers.
# The test cases are generated so that the answer fits in a 32-bits integer.

# The number of nodes in the tree is in the range [1, 1000].
# Node.val is 0 or 1.
require "./utils.rb"
# @param {TreeNode} root
# @return {Integer}
def sum_root_to_leaf(root)
    travel_tree(root,"",[]).map{|n| n.to_i(2)}.reduce(:+)
end
def travel_tree(root,current,numbers)
    if root.left.nil? and root.right.nil?
        numbers.append(current+root.val.to_s)
    else
        travel_tree(root.right,current+root.val.to_s,numbers) unless root.right.nil?
        travel_tree(root.left,current+root.val.to_s,numbers) unless root.left.nil?
    end
    numbers
end
l2_0 = TreeNode.new(0)
l2_1 = TreeNode.new(1)
l2_2 = TreeNode.new(0)
l2_3 = TreeNode.new(1)
l1_0 = TreeNode.new(0,l2_0,l2_1)
l1_1 = TreeNode.new(1,l2_2,l2_3)
l0_0 = TreeNode.new(1,l1_0,l1_1)
p sum_root_to_leaf(l0_0)==22
p sum_root_to_leaf(l2_0)==0