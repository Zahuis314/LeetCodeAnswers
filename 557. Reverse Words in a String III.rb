# Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

# 1 <= s.length <= 5 * 10^4
# s contains printable ASCII characters.
# s does not contain any leading or trailing spaces.
# There is at least one word in s.
# All the words in s are separated by a single space.


# @param {String} s
# @return {String}
def reverse_words(s)
    s.split.map(&:reverse).join ' '
end

p(reverse_words("Let's take LeetCode contest")) # "s'teL ekat edoCteeL tsetnoc"
p(reverse_words("God Ding")) # "doG gniD"