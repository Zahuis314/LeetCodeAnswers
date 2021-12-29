# Given an integer x, return true if x is palindrome integer.
# An integer is a palindrome when it reads the same backward as forward.
# For example, 121 is a palindrome while 123 is not.

# -2^31 <= x <= 2^31 - 1

# @param {Integer} x
# @return {Boolean}
def is_palindrome(x)
    return false if x<0
    x = x.to_s
    for i in 0..x.length/2 do
        return false if x[i] != x[-i-1]
    end
    true
end

def is_palindrome(x)
    x.to_s == x.to_s.reverse
end

p(is_palindrome(121)) #True
p(is_palindrome(123)) #False
p(is_palindrome(1221)) #True
p(is_palindrome(1223)) #False
p(is_palindrome(1)) #True
p(is_palindrome(0)) #True
p(is_palindrome(-121)) #False
p(is_palindrome(10)) #False