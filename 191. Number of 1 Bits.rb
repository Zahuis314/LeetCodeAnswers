# Write a function that takes an unsigned integer and returns the number of '1' bits it has (also known as the Hamming weight).
# Note:
# Note that in some languages, such as Java, there is no unsigned integer type. In this case, the input will be given as a signed integer type. It should not affect your implementation, as the integer's internal binary representation is the same, whether it is signed or unsigned.
# In Java, the compiler represents the signed integers using 2's complement notation. Therefore, in Example 3, the input represents the signed integer. -3.

# The input must be a binary string of length 32.

# @param {Integer} n, a positive integer
# @return {Integer}
def hamming_weight(n)
    n.to_s(2).count '1'
end

def hamming_weight_bit_manipulation(n)
    result = 0
    while n > 0
        result += n & 1
        n >>= 1
    end
    return result
end

p hamming_weight_bit_manipulation(11)==3
p hamming_weight_bit_manipulation(128)==1
p hamming_weight_bit_manipulation(4294967293)==31