// Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
// Notice that the solution set must not contain duplicate triplets.

// 0 <= nums.length <= 3000
// -10^5 <= nums[i] <= 10^5
var twoSum = function(nums, target){
    var left_index = 0, right_index = nums.length-1;
    var result = [];
    while(left_index < right_index){
        if(nums[left_index] + nums[right_index] == target){
            result.push([-target,nums[left_index], nums[right_index]]);
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
 * @return {number[][]}
 */
var threeSum = function(nums) {
    nums.sort((a,b)=>a-b);
    var result = [];
    for (let i = 0; i < nums.length; i++) {
        const element = nums[i];
        while(i>0 && nums[i]==nums[i-1]){i++;}
        var curr_res = twoSum(nums.slice(i+1),-nums[i]);
        result.push(...curr_res);
    }
    return result;
};

console.log(threeSum([-1,0,1,2,-1,-4,-2,-3,3,0,4])) 
//[[-4,0,4],[-4,1,3],[-3,-1,4],[-3,0,3],[-3,1,2],[-2,-1,3],[-2,0,2],[-1,-1,2],[-1,0,1]]
console.log(threeSum([-1,0,1,2,-1,-4])) //[[-1,-1,2],[-1,0,1]]
console.log(threeSum([0,0,0,0]))        //[0,0,0]
console.log(threeSum([]))               //[]
console.log(threeSum([0]))              //[]