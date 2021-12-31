# The count-and-say sequence is a sequence of digit strings defined by the recursive formula:
# countAndSay(1) = "1"
# countAndSay(n) is the way you would "say" the digit string from countAndSay(n-1), which is then converted into a different digit string.
# To determine how you "say" a digit string, split it into the minimal number of groups so that each group is a contiguous section all of the same character. Then for each group, say the number of characters, then say the character. To convert the saying into a digit string, replace the counts with a number and concatenate every saying.
# For example, the saying and conversion for digit string "3322251":
# two 3's, three 2's, one 5, and one 1 => 23 32 15 11 = 23321511
# Given a positive integer n, return the nth term of the count-and-say sequence.

# 1 <= n <= 30

# @param {Integer} n
# @return {String}
def count_and_say(n)
    return "1" if n==1
    previous = count_and_say(n-1)
    curr_num, curr_count = "0", 0
    result = ""
    previous.each_char do |num|
        if num != curr_num
            result += curr_count.to_s + curr_num
            curr_num, curr_count = num, 1
        else
            curr_count += 1
        end
    end
    result += curr_count.to_s + curr_num
    result[2..]
end

p(count_and_say(1) == "1")
p(count_and_say(2) == "11")
p(count_and_say(3) == "21")
p(count_and_say(4) == "1211")
p(count_and_say(5) == "111221")
p(count_and_say(6) == "312211")
p(count_and_say(7) == "13112221")
p(count_and_say(8) == "1113213211")
p(count_and_say(9) == "31131211131221")