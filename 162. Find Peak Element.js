// A peak element is an element that is strictly greater than its neighbors.
// Given an integer array nums, find a peak element, and return its index. If the array contains multiple peaks, return the index to any of the peaks.
// You may imagine that nums[-1] = nums[n] = -∞.
// You must write an algorithm that runs in O(log n) time.

// 1 <= nums.length <= 1000
// -2^31 <= nums[i] <= 2^31 - 1
// nums[i] != nums[i + 1] for all valid i.

/**
 * @param {number[]} nums
 * @return {number}
 */
var findPeakElement = function(nums) {
    var left = 0, right = nums.length-1;
    while (left < right){
        var middle = Math.floor((left+right)/2);
        if (nums[middle] > nums[middle+1]) {
            right = middle;
        }
        else {
            left = middle + 1;
        }
    }
    return left;
};
console.log(findPeakElement([3,10,5,3,2,8])==1);
console.log(findPeakElement([1,2,3,1])==2);
console.log(findPeakElement([1,2,1,3,5,6,4]));  // 2 or 5
