// Given an array nums of n integers, return an array of all the unique quadruplets [nums[a], nums[b], nums[c], nums[d]] such that:
// 0 <= a, b, c, d < n
// a, b, c, and d are distinct.
// nums[a] + nums[b] + nums[c] + nums[d] == target
// You may return the answer in any order.

// 1 <= nums.length <= 200
// -10^9 <= nums[i] <= 10^9
// -10^9 <= target <= 10^9
/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[][]}
 */
var twoSum = function(nums, target){
    var lo = 0, hi = nums.length-1;
    var result = [];
    while(lo < hi){
        var curr_sum = nums[lo] + nums[hi];
        if(curr_sum < target || (lo>0 && nums[lo]==nums[lo-1])){
            lo++;
        }else if(curr_sum > target || (hi<nums.length-1 && nums[hi]==nums[hi+1])){
            hi--;
        }else{
            result.push([nums[lo], nums[hi]]);
            hi--;
            lo++;
        }
    }
    return result;
}
/**
 * @param {number[]} nums
 * @param {number} target
 * @param {number} k
 * @return {number[][]}
 */
var kSum = function(nums,target,k){
    var average_val = Math.floor(target/k);
    if(nums.length<k || average_val < nums[0] || average_val > nums[nums.length-1]){
        return [];
    }
    var result = [];
    if(k==2){
        return twoSum(nums,target)
    }
    for (let i = 0; i < nums.length; i++) {
        if(i==0 || nums[i-1]!=nums[i]){

            var curr_res = kSum(nums.slice(i+1),target-nums[i],k-1);
            transformed = curr_res.map(arr=>[nums[i],...arr]);
            result.push(...transformed);
        }
    }
    return result;
}
/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[][]}
 */
var fourSum = function(nums, target) {
    nums.sort((a,b)=>a-b);
    return kSum(nums,target,4)
};

console.log(fourSum([1,0,-1,0,-2,2],0)) //[[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]
console.log(fourSum([2,2,2,2,2],8)) //[[2,2,2,2]]
console.log(fourSum([2,2,2,2,2,2,2,2,2],8)) //[[2,2,2,2]]
console.log(fourSum([2,2,2],8)) //[[2,2,2,2]]
console.log(fourSum([2,2,2,2],8)) //[[2,2,2,2]]
