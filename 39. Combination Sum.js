// Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target. You may return the combinations in any order.
// The same number may be chosen from candidates an unlimited number of times. Two combinations are unique if the frequency of at least one of the chosen numbers is different.
// It is guaranteed that the number of unique combinations that sum up to target is less than 150 combinations for the given input.

// 1 <= candidates.length <= 30
// 1 <= candidates[i] <= 200
// All elements of candidates are distinct.
// 1 <= target <= 500

var combinationSum = function(candidates, target) {
    var result = [];

    function permute(arr=[], sum=0, index=0) {
        if(sum > target) return;
        if(sum === target) result.push(arr);

        for(let i = index; i < candidates.length; i++) {
            permute([...arr, candidates[i]], sum+candidates[i], i);
        }
    }
    permute()
    return result; 
};

console.log(combinationSum([2,3,5], 8));
console.log(combinationSum([2], 1));
console.log(combinationSum([2], 8));