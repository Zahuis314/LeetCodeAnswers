# Definition for Node.
class Node
    attr_accessor :val, :left, :right, :next
    def initialize(val, left = nil, right = nil)
        @val = val
        @left, @right, @next = left, right, nil
    end
    def to_s()
        # return @val.to_s
        return [@val,@next.val].to_s
    end
end
class ListNode
    attr_accessor :val, :next
    def initialize(val = 0, _next = nil)
        @val = val
        @next = _next
    end
end
