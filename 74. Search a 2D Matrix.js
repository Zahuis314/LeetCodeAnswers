// Write an efficient algorithm that searches for a value target in an m x n integer matrix matrix. This matrix has the following properties:
// Integers in each row are sorted from left to right.
// The first integer of each row is greater than the last integer of the previous row.

// m == matrix.length
// n == matrix[i].length
// 1 <= m, n <= 100
// -10^4 <= matrix[i][j], target <= 10^4

/**
 * @param {number[][]} matrix
 * @param {number} target
 * @return {boolean}
 */
var searchMatrix = function(matrix, target) {
    var m = matrix.length;
    var n = matrix[0].length;
    var left = 0;
    var right = m*n-1;
    while (left <= right){
        var middle = Math.ceil((left+right)/2);
        var middleX = Math.floor(middle/n);
        var middleY = middle%n;
        if (matrix[middleX][middleY] == target){
            return true;
        }
        else if (matrix[middleX][middleY] < target) {
            left = middle + 1;
        }
        else if (matrix[middleX][middleY] > target) {
            right = middle - 1;
        }
    }
    return false;
};
console.log(searchMatrix([[1,3,5,7],[10,11,16,20],[23,30,34,60]],3)==true);
console.log(searchMatrix([[1,3,5,7],[10,11,16,20],[23,30,34,60]],13)==false);