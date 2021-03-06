# Definition for Node.
class Node
    attr_accessor :val, :left, :right, :next
    def initialize(val, left = nil, right = nil)
        @val = val
        @left, @right, @next = left, right, nil
    end
    def to_s()
        # return @val.to_s
        return [@val&.to_s,@next&.val].to_s
    end
end
class ListNode
    attr_accessor :val, :next
    def initialize(val = 0, _next = nil)
        @val = val
        @next = _next
    end
end
# @param {Array} arr
# @return {ListNode}
def convert_to_list_node(arr)
    ListNode.new(arr[0],arr.length != 1 ? convert_to_list_node(arr[1..]) : nil)
end
class TreeNode
    attr_accessor :val, :left, :right
    def initialize(val = 0, left = nil, right = nil)
        @val = val
        @left = left
        @right = right
    end
end
