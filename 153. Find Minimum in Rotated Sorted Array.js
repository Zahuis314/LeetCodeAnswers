// Suppose an array of length n sorted in ascending order is rotated between 1 and n times. For example, the array nums = [0,1,2,4,5,6,7] might become:
// [4,5,6,7,0,1,2] if it was rotated 4 times.
// [0,1,2,4,5,6,7] if it was rotated 7 times.
// Notice that rotating an array [a[0], a[1], a[2], ..., a[n-1]] 1 time results in the array [a[n-1], a[0], a[1], a[2], ..., a[n-2]].
// Given the sorted rotated array nums of unique elements, return the minimum element of this array.
// You must write an algorithm that runs in O(log n) time.

// n == nums.length
// 1 <= n <= 5000
// -5000 <= nums[i] <= 5000
// All the integers of nums are unique.
// nums is sorted and rotated between 1 and n times.

/**
 * @param {number[]} nums
 * @return {number}
 */
var findMin = function(nums) {
    var min = 0;
    var left = 0;
    var right = nums.length-1;
    while (left <= right){
        var middle = Math.ceil((left+right)/2);
        if (nums[middle] > nums[min]) {
            left = middle + 1;
        }
        else{
            right = middle - 1;
            min = middle;
        }
    }
    return nums[left % nums.length];
};

// console.log(findMin([3,4,5,1,2])==1);
console.log(findMin([6,1,2,3,4,5]));    // 1
console.log(findMin([1,2,3,4,5,6]));    // 0
console.log(findMin([2,3,4,5,6,1]));    // 5
console.log(findMin([3,4,5,6,1,2]));    // 4
console.log(findMin([4,5,6,7,0,1,2]));  // 4
console.log(findMin([11,13,15,17]));    // 0