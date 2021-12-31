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
