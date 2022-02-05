// There is an integer array nums sorted in ascending order (with distinct values).
// Prior to being passed to your function, nums is possibly rotated at an unknown pivot index k (1 <= k < nums.length) such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). For example, [0,1,2,4,5,6,7] might be rotated at pivot index 3 and become [4,5,6,7,0,1,2].
// Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.
// You must write an algorithm with O(log n) runtime complexity.

// 1 <= nums.length <= 5000
// -10^4 <= nums[i] <= 10^4
// All values of nums are unique.
// nums is an ascending array that is possibly rotated.
// -10^4 <= target <= 10^4

/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var search = function(nums, target) {
    var left = 0;
    var right = nums.length-1;
    while (left <= right){
        var middle = Math.ceil((left+right)/2);
        if(nums[middle] == target){
            return middle;
        }
        else if (nums[middle] <= nums[right]) {
            if (target > nums[middle] && target <= nums[right]) {
                left = middle + 1;
            } else {
                right = middle - 1;
            }
        }
        else{
            if (target > nums[middle] || target < nums[left]) {
                left = middle + 1;
            } else {
                right = middle - 1;
            }
        }
    }
    return -1;
};

console.log(search([4,5,6,7,0,1,2],0)==4);
console.log(search([4,5,6,7,0,1,2],3)==-1);
console.log(search([1],0)==-1);
console.log(search([3,4,5,1,2],3)==0);
console.log(search([3,4,5,1,2],4)==1);
console.log(search([3,4,5,1,2],5)==2);
console.log(search([3,4,5,1,2],1)==3);
console.log(search([3,4,5,1,2],2)==4);
