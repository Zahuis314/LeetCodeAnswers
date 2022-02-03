// Given four integer arrays nums1, nums2, nums3, and nums4 all of length n, return the number of tuples (i, j, k, l) such that:
// 0 <= i, j, k, l < n
// nums1[i] + nums2[j] + nums3[k] + nums4[l] == 0

// n == nums1.length
// n == nums2.length
// n == nums3.length
// n == nums4.length
// 1 <= n <= 200
// -2^28 <= nums1[i], nums2[i], nums3[i], nums4[i] <= 2^28

/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @param {number[]} nums3
 * @param {number[]} nums4
 * @return {number}
 */
var fourSumCount = function(nums1, nums2, nums3, nums4) {
    var dict = {}, result = 0;
    nums1.forEach(x => {
        nums2.forEach(y => {
            if(dict[x+y]){
                dict[x+y]++;
            }else{
                dict[x+y]=1;
            }
        });
    });
    nums3.forEach(x => {
        nums4.forEach(y => {
            if(dict[-(x+y)]){
                result+=dict[-(x+y)];
            }
        });
    });
    return result;
};

console.log(fourSumCount([1,2], [-2,-1], [-1,2], [0,2])==2)
console.log(fourSumCount([0], [0], [0], [0])==1)