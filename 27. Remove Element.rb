# Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The relative order of the elements may be changed.
# Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums. More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result. It does not matter what you leave beyond the first k elements.
# Return k after placing the final result in the first k slots of nums.
# Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.

# 0 <= nums.length <= 100
# 0 <= nums[i] <= 50
# 0 <= val <= 100

# @param {Integer[]} nums
# @param {Integer} val
# @return {Integer}
def remove_element(nums, val)
    inserting_point, searching_point = 0,0
    while searching_point < nums.length
        if nums[searching_point] != val
            nums[inserting_point] = nums[searching_point]
            inserting_point += 1
        end
        searching_point +=1
    end
    inserting_point
end
nums = [3,2,2,3]
print(remove_element(nums,3)) # 2, nums = [2,2,_,_]
print nums

nums = [0,1,2,2,3,0,4,2]
print(remove_element(nums,2)) # 5, nums = [0,1,4,0,3,_,_,_]
print nums