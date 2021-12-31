# Given the root of a binary tree, find the maximum value v for which there exist different nodes a and b where v = |a.val - b.val| and a is an ancestor of b.
# A node a is an ancestor of b if either: any child of a is equal to b or any child of a is an ancestor of b.

# The number of nodes in the tree is in the range [2, 5000].
# 0 <= Node.val <= 10^5

# Definition for a binary tree node.
# class TreeNode
#     attr_accessor :val, :left, :right
#     def initialize(val = 0, left = nil, right = nil)
#         @val = val
#         @left = left
#         @right = right
#     end
# end
require "./utils.rb"
# @param {TreeNode} root
# @return {Integer}
def max_ancestor_diff(root)
    return max_ancestor_dif_recursive_efficient(root, root.val, root.val)
    return max_ancestor_dif_recursive(root)[0]
end

# @param {TreeNode} root
# @return {Integer,Integer,Integer}   result,min, max
def max_ancestor_dif_recursive(root)
    return [nil,nil,nil] if root.nil?        
    return [0,root.val,root.val] if root.left.nil? and root.right.nil?

    left_result = max_ancestor_dif_recursive(root.left)
    right_result = max_ancestor_dif_recursive(root.right)
    min,max = (left_result[1..] + right_result[1..] + [root.val]).reject{|x| x.nil?}.minmax
    curr_max = [(root.val-min).abs, (root.val-max).abs, left_result[0], right_result[0]].reject{|x| x.nil?}.max
    [curr_max, min, max]
end

def max_ancestor_dif_recursive_efficient(root, cur_max, cur_min)
    return cur_max - cur_min if root.nil?
        
    cur_min, cur_max = [cur_min, root.val, cur_max].minmax
    left = max_ancestor_dif_recursive_efficient(root.left, cur_max, cur_min)
    right = max_ancestor_dif_recursive_efficient(root.right, cur_max, cur_min)
    [left, right].max
end

n4 = Node.new(4)
n7 = Node.new(7)
n13 = Node.new(13)
n1 = Node.new(1)
n6 = Node.new(6,n4,n7)
n14 = Node.new(14,n13)
n3 = Node.new(3,n1,n6)
n10 = Node.new(10,nil,n14)
n8 = Node.new(8,n3,n10)

print(max_ancestor_diff(n8)) #7

n3 = Node.new(3)
n0 = Node.new(0,n3,nil)
n2 = Node.new(2,nil,n0)
n1 = Node.new(1,nil,n2)

print(max_ancestor_diff(n1)) #3

n1 = Node.new(1)
n0 = Node.new(0,n1,nil)
n2 = Node.new(2,nil,n0)

print(max_ancestor_diff(n2)) #2