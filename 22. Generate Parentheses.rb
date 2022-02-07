# Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

# 1 <= n <= 8

# @param {Integer} n
# @return {String[]}
def generate_parenthesis(n)
    result = [];
    queue = [["(",n-1,n]]
    until queue.empty?
        str,o_c,c_c = queue.shift
        if o_c == 0 and c_c == 0
            result << str
        else
            queue << [str+"(",o_c-1,c_c] if o_c != 0
            queue << [str+")",o_c,c_c-1] if c_c != 0 && c_c > o_c
        end
    end
    result
end

p generate_parenthesis(1)
p generate_parenthesis(2)
p generate_parenthesis(3)
p generate_parenthesis(4)
p generate_parenthesis(5)