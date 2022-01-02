# Given a string s consisting of only the characters 'a' and 'b', return true if every 'a' appears before every 'b' in the string. Otherwise, return false.

# 1 <= s.length <= 100
# s[i] is either 'a' or 'b'.

# @param {String} s
# @return {Boolean}
def check_string(s)
    last = 'a'
    s.each_char do |c|
        if c=='a' and last == 'b'
            return false
        elsif c== 'b'
            last = 'b'
        end
    end
    return true
end

p check_string("aaabbb") #True
p check_string("abab") #False