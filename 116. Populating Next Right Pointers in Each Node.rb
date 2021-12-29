# You are given a perfect binary tree where all leaves are on the same level, and every parent has two children. The binary tree has the following definition:
# struct Node {
#   int val;
#   Node *left;
#   Node *right;
#   Node *next;
# }
# Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to NULL.
# Initially, all next pointers are set to NULL.

# The number of nodes in the tree is in the range [0, 2^12 - 1].
# -1000 <= Node.val <= 1000

require "./utils.rb"
# @param {Node} root
# @return {Node}
def connect(root)
    unless root.nil?
        queue = [root, nil]
        until queue.empty?
            current = queue.shift
            current.next = queue.first
            queue.push(current.left, current.right) unless current.left.nil?
            if current.next.nil?
                queue.shift
                queue.push(nil) unless current.left.nil?
            end
        end
        return root
    end
end

r1 = Node.new(1)
r2 = Node.new(2)
r3 = Node.new(3)
r4 = Node.new(4)
r5 = Node.new(5)
r6 = Node.new(6)
r7 = Node.new(7)

r1.left = r2
r1.right = r3
r2.left = r4
r2.right = r5
r3.left = r6
r3.right = r7
r4.left = nil
r4.right = nil
r5.left = nil
r5.right = nil
r6.left = nil
r6.right = nil
r7.left = nil
r7.right = nil

a = connect(r1)

p connect(nil)