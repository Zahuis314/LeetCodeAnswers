# Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same.
# Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums. More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result. It does not matter what you leave beyond the first k elements.
# Return k after placing the final result in the first k slots of nums.
# Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.

# 0 <= nums.length <= 3 * 10^4
# -100 <= nums[i] <= 100
# nums is sorted in non-decreasing order.

# @param {Integer[]} nums
# @return {Integer}
def remove_duplicates(nums)
    return 0 if nums.empty?
    slow, fast = 0,1
    while fast < nums.length
        if nums[fast] != nums[slow]
            slow += 1
            nums[slow] = nums[fast]
        end
        nums[fast]=nil
        fast +=1
    end
    slow + 1
end
test1 = [1,2,2]
p(remove_duplicates(test1)) # 2, [1,2,_]
test2 = [0,0,1,1,1,2,2,3,3,4]
p(remove_duplicates(test2)) # 5, [0,1,2,3,4,_,_,_,_,_]