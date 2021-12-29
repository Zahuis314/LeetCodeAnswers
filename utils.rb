# Definition for Node.
class Node
    attr_accessor :val, :left, :right, :next
    def initialize(val)
        @val = val
        @left, @right, @next = nil, nil, nil
    end
    def to_s()
        return @val.to_s
    end
end
