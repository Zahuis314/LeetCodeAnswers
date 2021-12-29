# Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number. Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 <= numbers.length.
# Return the indices of the two numbers, index1 and index2, added by one as an integer array [index1, index2] of length 2.
# The tests are generated such that there is exactly one solution. You may not use the same element twice.

# 2 <= numbers.length <= 3 * 10^4
# -1000 <= numbers[i] <= 1000
# numbers is sorted in non-decreasing order.
# -1000 <= target <= 1000
# The tests are generated such that there is exactly one solution.

# @param {Integer[]} numbers
# @param {Integer} target
# @return {Integer[]}
def two_sum(numbers, target)
    left_index = 0
    right_index = numbers.length-1
    while numbers[left_index] + numbers[right_index] != target do
        if numbers[left_index] + numbers[right_index] > target
            right_index -= 1
        else
            left_index += 1
        end
    end
    return [left_index+1, right_index+1]
end

print(two_sum([2,7,11,15],9)) #[1,2]
print(two_sum([2,3,4],6)) #[1,3]
print(two_sum([-1,0],-1)) #[1,2]
