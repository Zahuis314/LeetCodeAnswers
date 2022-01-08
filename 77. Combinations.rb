# Given two integers n and k, return all possible combinations of k numbers out of the range [1, n].
# You may return the answer in any order.

# 1 <= n <= 20
# 1 <= k <= n

# @param {Integer} n
# @param {Integer} k
# @return {Integer[][]}
def combine(n, k)
    (1..n).to_a.combination(k).to_a
end