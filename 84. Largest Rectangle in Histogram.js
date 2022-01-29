// Given an array of integers heights representing the histogram's bar height where the width of each bar is 1, return the area of the largest rectangle in the histogram.

// 1 <= heights.length <= 10^5
// 0 <= heights[i] <= 10^4

/**
 * @param {number[]} heights
 * @return {number}
 */
var largestRectangleArea = function(heights) {
    heights.push(0);
    var max=0;
    var queue = [];
    heights.forEach((height,index) => {
        var currentIndex = index;
        while(queue.length!=0 && queue[queue.length-1][1]>height){
            var top = queue.pop();
            var currentWidth = index-top[0];
            max = Math.max(currentWidth*top[1],max);
            currentIndex = top[0];
        }
        queue.push([currentIndex,height]);
    });
    return max;
};

console.log(largestRectangleArea([2,1,5,6,2,3])==10);
console.log(largestRectangleArea([2,4])==4);