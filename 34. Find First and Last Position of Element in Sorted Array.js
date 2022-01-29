// Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.
// If target is not found in the array, return [-1, -1].
// You must write an algorithm with O(log n) runtime complexity.

// 0 <= nums.length <= 10^5
// -10^9 <= nums[i] <= 10^9
// nums is a non-decreasing array.
// -10^9 <= target <= 10^9

var binarySearch = function(nums, target, first){
    var left = 0;
    var right = nums.length-1;
    var res = -1;
    while (left <= right){
        var middle = Math.ceil((left+right)/2);
        if (nums[middle] < target) {
            left = middle + 1;
        }
        else if (nums[middle] > target) {
            right = middle - 1;
        }
        else{
            res = middle;
            if (first){
                right = middle - 1;
            }else{
                left = middle + 1;
            }
        }
    }
    return res;
}
/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var searchRange = function(nums, target) {
    var left = binarySearch(nums,target,true);
    var right = binarySearch(nums,target,false);
    return [left,right];
};
console.log(searchRange([5,7,7,8,8,10],8)); //[3,4]
console.log(searchRange([5,7,7,8,8,8,8,8,8,9,10],8)); //[3,8]
console.log(searchRange([5,7,7,8,8,10],6)); //[-1,-1]
console.log(searchRange([],0)); //[-1,-1]