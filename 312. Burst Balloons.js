// You are given n balloons, indexed from 0 to n - 1. Each balloon is painted with a number on it represented by an array nums. You are asked to burst all the balloons.
// If you burst the ith balloon, you will get nums[i - 1] * nums[i] * nums[i + 1] coins. If i - 1 or i + 1 goes out of bounds of the array, then treat it as if there is a balloon with a 1 painted on it.
// Return the maximum coins you can collect by bursting the balloons wisely.

// n == nums.length
// 1 <= n <= 300
// 0 <= nums[i] <= 100

/**
 * @param {number[]} nums
 * @return {number}
 */
var maxCoins = function(nums) {
    nums.push(1);
    nums.unshift(1);
    var dp = []
    for (let index = 0; index < nums.length; index++) {
        dp.push(new Array(nums.length).fill(0));
    }
    for (let length = 1; length < nums.length - 1; length++) {
        for (let begin = 1; begin < nums.length - length; begin++) {
            var end = begin+length-1;
            for (var last = begin; last < end + 1; last++)
            {
                var curr_prev = dp[begin][last - 1];
                var curr = nums[begin - 1] * nums[last] * nums[end + 1];
                var curr_next = dp[last + 1][end];
                var curr_val = curr_prev + curr + curr_next;
                dp[begin][end] = Math.max(dp[begin][end], curr_val);
            }
        }
    }
    return dp[1][nums.length-2];
};

console.log(maxCoins([3,1,5,8])==167);
console.log(maxCoins([1,5])==10);