# Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
# You may assume that each input would have exactly one solution, and you may not use the same element twice.
# You can return the answer in any order.

# 2 <= nums.length <= 10^4
# -10^9 <= nums[i] <= 10^9
# -10^9 <= target <= 10^9
# Only one valid answer exists.

# @param {Integer[]} nums
# @param {Integer} target
# @return {Integer[]}
def two_sum(nums, target)
    sorted = nums.each_with_index.to_a.sort
    left_index = 0
    right_index = sorted.length-1
    while sorted[left_index][0] + sorted[right_index][0] != target do
        if sorted[left_index][0] + sorted[right_index][0] > target
            right_index -= 1
        else
            left_index += 1
        end
    end
    return [sorted[left_index][1],sorted[right_index][1]]
end

def two_sum_with_hash(nums, target)
    visited = {}
    nums.each_with_index do |item,index|
        complement = visited[target-item]
        if complement.nil?
            visited[item] = [item,index]
        else
            return [complement[1],index]
        end
    end
end

print(two_sum_with_hash([2,7,11,15],9))
print(two_sum_with_hash([3,2,4],6))
print(two_sum_with_hash([3,3],6))

