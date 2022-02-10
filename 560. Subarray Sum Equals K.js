// Given an array of integers nums and an integer k, return the total number of continuous subarrays whose sum equals to k.

// 1 <= nums.length <= 2 * 10^4
// -1000 <= nums[i] <= 1000
// -10^7 <= k <= 10^7

/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number}
 */
var subarraySum = function(nums, k) {
    var result = 0, current = 0;
    var map = {}
    nums.forEach(num => {
        current += num;
        if(current==k) result++;
        if(map[current-k]) result += map[current-k];
        if(map[current])
            map[current]++;
        else
            map[current]=1;
    });
    return result;
};
console.log(subarraySum(nums = [1,1,1], k = 2)==2)
console.log(subarraySum(nums = [1,2,3], k = 3)==2)