// Given an array of integers nums and an integer k, return the number of unique k-diff pairs in the array.
// A k-diff pair is an integer pair (nums[i], nums[j]), where the following are true:
// 0 <= i < j < nums.length
// |nums[i] - nums[j]| == k
// Notice that |val| denotes the absolute value of val.

const { result } = require("lodash");

// 1 <= nums.length <= 10^4
// -10^7 <= nums[i] <= 10^7
// 0 <= k <= 10^7

/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number}
 */
var findPairs = function(nums, k) {
    nums.sort((a,b)=>a-b);
    var hash = {}, result = 0;
    for (let i = 0; i < nums.length; i++) {
        const element = nums[i];
        if(k!=0){
            while (i < nums.length && element == nums[i+1]) i++;
            if(hash[element-k]){
                result++;
            }
            if(hash[element+k]){
                result++;
            }
            hash[element]=true;
        }else{
            if(i < nums.length && element == nums[i+1]){
                while (i < nums.length && element == nums[i+1]) i++;
                result++;
            }
        }
    }
    return result;
};

console.log(findPairs(nums = [3,1,4,1,5], k = 2)==2);
console.log(findPairs(nums = [1,2,3,4,5], k = 1)==4);
console.log(findPairs(nums = [1,3,1,5,4], k = 0)==1);
console.log(findPairs(nums = [3,1,4,1,5,5], k = 2)==2);
console.log(findPairs(nums = [3,1], k = 2)==1)
console.log(findPairs(nums = [3], k = 2)==0)