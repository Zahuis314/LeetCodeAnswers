// You are given an array prices where prices[i] is the price of a given stock on the ith day.
// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
// Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

// 1 <= prices.length <= 10^5
// 0 <= prices[i] <= 10^4

/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function(prices) {
    var max = 0, max_profit = 0;
    for (let i = prices.length-1; i >= 0; i--) {
        max = Math.max(max,prices[i]);
        max_profit = Math.max(max_profit,max-prices[i]);
    }
    return max_profit;
};
console.log(maxProfit([7,1,5,3,6,4])==5);
console.log(maxProfit([7])==0);
console.log(maxProfit([7,1])==0);
console.log(maxProfit([1,7])==6);
console.log(maxProfit([7,6,4,3,1])==0);
console.log(maxProfit([1,2,3,4,5,6,7,8])==7);