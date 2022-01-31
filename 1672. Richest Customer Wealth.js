// You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has.
// A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.

// m == accounts.length
// n == accounts[i].length
// 1 <= m, n <= 50
// 1 <= accounts[i][j] <= 100

/**
 * @param {number[][]} accounts
 * @return {number}
 */
var maximumWealth = function(accounts) {
    var max = 0;
    accounts.forEach(account => {
        var curr = 0;
        account.forEach(money => {
            curr+=money;
        });
        max = Math.max(max,curr);
    });
    return max;
};

console.log(maximumWealth([[1,2,3],[3,2,1]])==6);
console.log(maximumWealth([[1,5],[7,3],[3,5]])==10);
console.log(maximumWealth([[2,8,7],[7,1,3],[1,9,5]])==17);