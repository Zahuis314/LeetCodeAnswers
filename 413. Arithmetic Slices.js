// An integer array is called arithmetic if it consists of at least three elements and if the difference between any two consecutive elements is the same.
// For example, [1,3,5,7,9], [7,7,7,7], and [3,-1,-5,-9] are arithmetic sequences.
// Given an integer array nums, return the number of arithmetic subarrays of nums.
// A subarray is a contiguous subsequence of the array.

// 1 <= nums.length <= 5000
// -1000 <= nums[i] <= 1000

/**
 * @param {number[]} nums
 * @return {number}
 */
var numberOfArithmeticSlices = function(nums) {
    if(nums.length<3) return 0;
    var result=0, dp = Array(nums.length).fill(0,0,2);
    for (let i = 2; i < nums.length; i++) {
        dp[i] = (nums[i]-nums[i-1] == nums[i-1]-nums[i-2]) ? dp[i-1]+1 : 0;
        result += dp[i];
    }
    return result;
};

console.log(numberOfArithmeticSlices([1,2,3,4])==3)
console.log(numberOfArithmeticSlices([1,2,3,4,5])==6)
console.log(numberOfArithmeticSlices([1,2,3,4,5,6])==10)
console.log(numberOfArithmeticSlices([1,2,3,4,5,6,1,2,3])==11)
console.log(numberOfArithmeticSlices([1])==0)