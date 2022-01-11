#Given a binary array nums, return the maximum number of consecutive 1's in the array.

# 1 <= nums.length <= 10^5
# nums[i] is either 0 or 1.


# @param {Integer[]} nums
# @return {Integer}
def find_max_consecutive_ones(nums)
    max,current=0,0
    nums.each do |n|
        if n==1
            current+=1
            max =[max,current].max
        else
            current=0
        end
    end
    max
end

p find_max_consecutive_ones([1,1,0,1,1,1])==3
p find_max_consecutive_ones([1,0,1,1,0,1])==2