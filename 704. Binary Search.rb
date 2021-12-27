# Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.
# You must write an algorithm with O(log n) runtime complexity.

# 1 <= nums.length <= 10^4
# -10^4 < nums[i], target < 10^4
# All the integers in nums are unique.
# nums is sorted in ascending order.

# @param {Integer[]} nums
# @param {Integer} target
# @return {Integer}
def search(nums, target)
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
    return -1
end

print(search([-1,0,3,5,9,12],9))   #4
print(search([-1,0,3,5,9,12],2))   #-1
