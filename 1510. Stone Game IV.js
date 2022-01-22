// Alice and Bob take turns playing a game, with Alice starting first.
// Initially, there are n stones in a pile. On each player's turn, that player makes a move consisting of removing any non-zero square number of stones in the pile.
// Also, if a player cannot make a move, he/she loses the game.
// Given a positive integer n, return true if and only if Alice wins the game otherwise return false, assuming both players play optimally.

// 1 <= n <= 10^5
/**
 * @param {number} n
 * @return {boolean}
 */
var computeSquares = function(n) {
    var result = new Array();
    for (let i = 1; i**2 <= n; i++) {
        result.push(i**2);
    }
    return result;
}
var winnerSquareGame = function(n) {
    var squares = computeSquares(n);
    var dp = {0:false};
    for (let i = 1; i <= n; i++) {
        dp[i]=false;
        for (let j = 0; squares[j] <= i; j++) {
            if(dp[i-squares[j]]==false){
                dp[i]=true;
                break;
            }
        }
    }
    return dp[n];
};
console.log(winnerSquareGame(1));
console.log(winnerSquareGame(2));
console.log(winnerSquareGame(3));
console.log(winnerSquareGame(4));
console.log(winnerSquareGame(5));
console.log(winnerSquareGame(6));
console.log(winnerSquareGame(7));
console.log(winnerSquareGame(8));
console.log(winnerSquareGame(9));
console.log(winnerSquareGame(10));
console.log(winnerSquareGame(11));
console.log(winnerSquareGame(12));
console.log(winnerSquareGame(13));
console.log(winnerSquareGame(14));
console.log(winnerSquareGame(15));
console.log(winnerSquareGame(16));
console.log(winnerSquareGame(17));
console.log(winnerSquareGame(18));
console.log(winnerSquareGame(19));