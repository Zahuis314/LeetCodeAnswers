# Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
# You must write an algorithm with O(log n) runtime complexity.

# 1 <= nums.length <= 10^4
# -10^4 <= nums[i] <= 10^4
# nums contains distinct values sorted in ascending order.
# -10^4 <= target <= 10^4


# @param {Integer[]} nums
# @param {Integer} target
# @return {Integer}
def search_insert(nums, target)
    left = 0
    right = nums.length-1
    while left <= right do
        middle = (left+right)/2
        if nums[middle] == target
            return middle
        elsif nums[middle] < target
            left = middle + 1
        else
            right = middle - 1
        end
    end
    return left
end

print(search_insert([1,3,5,6],5))   #2
print(search_insert([1,3,5,6],2))   #1
print(search_insert([1,3,5,6],7))   #4