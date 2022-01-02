# Anti-theft security devices are activated inside a bank. You are given a 0-indexed binary string array bank representing the floor plan of the bank, which is an m x n 2D matrix. bank[i] represents the ith row, consisting of '0's and '1's. '0' means the cell is empty, while'1' means the cell has a security device.
# There is one laser beam between any two security devices if both conditions are met:
# The two devices are located on two different rows: r1 and r2, where r1 < r2.
# For each row i where r1 < i < r2, there are no security devices in the ith row.
# Laser beams are independent, i.e., one beam does not interfere nor join with another.
# Return the total number of laser beams in the bank.

# m == bank.length
# n == bank[i].length
# 1 <= m, n <= 500
# bank[i][j] is either '0' or '1'.

# @param {String[]} bank
# @return {Integer}
def number_of_beams(bank)
    per_floor = bank.map {|f| f.count "1"}
    per_floor.delete_if {|f| f==0}
    return 0 if per_floor.length == 1
    total = 0
    (per_floor.length-1).times do |index|
        total += per_floor[index+1]*per_floor[index]
    end
    total
end

p number_of_beams(["011001","000000","010100","001000"]) #8
p number_of_beams(["000","111","000"]) #0