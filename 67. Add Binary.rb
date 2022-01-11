# Given two binary strings a and b, return their sum as a binary string.

# 1 <= a.length, b.length <= 10^4
# a and b consist only of '0' or '1' characters.
# Each string does not contain leading zeros except for the zero itself.

# @param {String} a
# @param {String} b
# @return {String}
def add_binary(a, b)
   result, carry, i = "", 0, 0
   while i<a.length or i<b.length
        sum = carry
        sum += a[-i-1].to_i if i<a.length
        sum += b[-i-1].to_i if i<b.length
        result += (sum % 2).to_s
        carry = sum > 1 ? 1 : 0
        i+=1
    end
    result += carry.to_s if carry == 1
    return result.reverse
end

p add_binary("11","1")=="100"
p add_binary("1010","1011")=="10101"
p add_binary("101","1011")=="10000"