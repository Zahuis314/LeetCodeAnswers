# The complement of an integer is the integer you get when you flip all the 0's to 1's and all the 1's to 0's in its binary representation.
# For example, The integer 5 is "101" in binary and its complement is "010" which is the integer 2.
# Given an integer num, return its complement.

# 1 <= num < 2^31

# @param {Integer} num
# @return {Integer}
def find_complement(num)
    num_of_bits = num.to_s(2).length
    all_ones_same_size = 2**(num_of_bits)
    return (all_ones_same_size-1)^num
end

print(find_complement(5)) #2
print(find_complement(1)) #0