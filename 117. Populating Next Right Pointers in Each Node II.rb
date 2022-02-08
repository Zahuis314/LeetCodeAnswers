# Given a binary tree
# struct Node {
#   int val;
#   Node *left;
#   Node *right;
#   Node *next;
# }
# Populate each next pointer to point to its next right node. If there is no next right node, the next pointer should be set to NULL.
# Initially, all next pointers are set to NULL.

# The number of nodes in the tree is in the range [0, 6000].
# -100 <= Node.val <= 100

require "./utils.rb"
# @param {Node} root
# @return {Node}
def connect(root)
    unless root.nil?
        queue = [root, nil]
        until queue.empty?
            current = queue.shift
            unless current.nil?
                current.next = queue.first
                queue.push current.left unless current.left.nil?
                queue.push current.right unless current.right.nil?
                if current.next.nil?
                    queue.shift
                    queue.push(nil)
                end
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

r4_l = Node.new(4)
r4_r = Node.new(4)
r3_l = Node.new(3, r4_l, nil)
r3_r = Node.new(3, nil, r4_r)
r2_l = Node.new(2, r3_l, nil)
r2_r = Node.new(2, nil, r3_r)
r1_c = Node.new(1, r2_l, r2_r)
a = connect(r1_c)
p 'end'
