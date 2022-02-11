# Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. Return the answer in any order.
# A mapping of digit to letters (just like on the telephone buttons) is given below. Note that 1 does not map to any letters.

# 0 <= digits.length <= 4
# digits[i] is a digit in the range ['2', '9'].

# @param {String} digits
# @return {String[]}
def letter_combinations(digits)
    ## First
    # return [] if digits.length == 0
    # letters = { "2" => "a".."c", "3" => "d".."f", "4" => "g".."i",
    #             "5" => "j".."l",  "6" => "m".."o", "7" => "p".."s",
    #             "8" => "t".."v", "9" => "w".."z"}
    # digits.each_char.reduce([""]) do |acum, digit|
    #     acum.map{|prefix| letters[digit].map{|letter| prefix+letter}}.flatten
    # end

    ## Shortest
    letters = "- - abc def ghi jkl mno pqrs tuv wxyz".split
    charsets = digits.chars.map { |d| letters[d.to_i].chars }
    digits == "" ? [] : [''].product(*charsets).map(&:join)
end

p letter_combinations("")
p letter_combinations("23")
p letter_combinations("4")
p letter_combinations("293")