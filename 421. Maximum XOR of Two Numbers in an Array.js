// Given an integer array nums, return the maximum result of nums[i] XOR nums[j], where 0 <= i <= j < n.

// 1 <= nums.length <= 2 * 10^5
// 0 <= nums[i] <= 2^31 - 1

/**
 * @param {number[]} nums
 * @return {number}
 */
var findMaximumXOR = function(nums) {
    var max = 0, mask = 0;
    var set = new Set();
    for (let bit_index = 31; bit_index >= 0; bit_index--) {
        mask |= (1<<bit_index);
        var possible_max = max | (1<<bit_index);
        nums.forEach(num => {
            set.add(num & mask);
        });
        for (const element of set.keys()) {
            if (set.has(possible_max ^ element)){
                max = possible_max;
                break;
            }
        }
        set.clear();
    }
    return max;
}

console.log(findMaximumXOR([3,10,5,25,2,8]));   //28
console.log(findMaximumXOR([14,70,53,83,49,91,36,80,92,51,66,70])); //127