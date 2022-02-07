# You are given two strings s and t.
# String t is generated by random shuffling string s and then add one more letter at a random position.
# Return the letter that was added to t.

# 0 <= s.length <= 1000
# t.length == s.length + 1
# s and t consist of lowercase English letters.

# @param {String} s
# @param {String} t
# @return {Character}
def find_the_difference(s, t)
    count_hash = Hash.new(0)
    t.each_char{|c| count_hash[c]+=1}
    s.each_char{|c| count_hash[c]-=1}
    count_hash.each_pair{|k,v| return k if v==1}
end

p find_the_difference("abcd","abcde")=="e"
p find_the_difference("abcd","dbaec")=="e"
p find_the_difference("abcd","edcba")=="e"
p find_the_difference("a","ab")=="b"
p find_the_difference("a","ba")=="b"
p find_the_difference("","b")=="b"