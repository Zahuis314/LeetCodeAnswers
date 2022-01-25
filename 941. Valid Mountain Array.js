// Given an array of integers arr, return true if and only if it is a valid mountain array.
// Recall that arr is a mountain array if and only if:
// arr.length >= 3
// There exists some i with 0 < i < arr.length - 1 such that:
// arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
// arr[i] > arr[i + 1] > ... > arr[arr.length - 1]

// 1 <= arr.length <= 104
// 0 <= arr[i] <= 104
/**
 * @param {number[]} arr
 * @return {boolean}
 */
var validMountainArray = function(arr) {
    var i=1;
    var increment=false,decrement=false;
    while (arr[i] > arr[i-1] && i<arr.length){
        i++;
        increment = true;
    }
    while (arr[i] < arr[i-1] && i<arr.length){
        i++;
        decrement = true;
    }
    return i==arr.length && increment && decrement;
};
console.log(validMountainArray([2,1])==false);
console.log(validMountainArray([3,5,5])==false);
console.log(validMountainArray([0,3,2,1])==true);
console.log(validMountainArray([0,3,1])==true);
console.log(validMountainArray([0,3,5,5,6])==false);
console.log(validMountainArray([3,5,6,3,2,2,1])==false);
console.log(validMountainArray([3,5,6,3,2,1,10])==false);