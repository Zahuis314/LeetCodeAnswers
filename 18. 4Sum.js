// Given an array nums of n integers, return an array of all the unique quadruplets [nums[a], nums[b], nums[c], nums[d]] such that:
// 0 <= a, b, c, d < n
// a, b, c, and d are distinct.
// nums[a] + nums[b] + nums[c] + nums[d] == target
// You may return the answer in any order.

// 1 <= nums.length <= 200
// -10^9 <= nums[i] <= 10^9
// -10^9 <= target <= 10^9

var twoSum = function(nums, target){
    var left_index = 0, right_index = nums.length-1;
    var result = [];
    while(left_index < right_index){
        if(nums[left_index] + nums[right_index] == target){
            result.push([nums[left_index], nums[right_index]]);
            while(nums[left_index]==nums[left_index+1]){
                left_index++;
            }
            while(nums[right_index]==nums[right_index-1]){
                right_index--;
            }
            left_index++;
        }else if(nums[left_index] + nums[right_index] > target){
            right_index--;
        }else{
            left_index++;
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
    var result = [];
    for (let i = 0; i < nums.length-3; i++) {
        while(i>0 && nums[i]==nums[i-1]){i++;}
        for (let j = i+1; j < nums.length-2; j++) {
            while(j>0 && j!=i+1 && nums[j]==nums[j-1]){j++;}
            var curr_res = twoSum(nums.slice(j+1),target-(nums[i]+nums[j]));
            transformed = curr_res.map(arr=>[nums[i],nums[j],...arr]);
            result.push(...transformed);
        }
    }
    return result;
};

console.log(fourSum([1,0,-1,0,-2,2],0)) //[[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]
console.log(fourSum([2,2,2,2,2],8)) //[[2,2,2,2]]
console.log(fourSum([2,2,2,2,2,2,2,2,2],8)) //[[2,2,2,2]]
console.log(fourSum([2,2,2],8)) //[[2,2,2,2]]
console.log(fourSum([2,2,2,2],8)) //[[2,2,2,2]]
