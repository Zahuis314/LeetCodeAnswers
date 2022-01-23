// An integer has sequential digits if and only if each digit in the number is one more than the previous digit.
// Return a sorted list of all the integers in the range [low, high] inclusive that have sequential digits.

// 10 <= low <= high <= 10^9

/**
 * @param {number} low
 * @param {number} high
 * @return {number[]}
 */
const makeNum = (length, first) => {
    var result = first;
    while (--length) {
        first +=1;
        result = result * 10 + first;
    }
    return result;
};
var sequentialDigits = function(low, high) {
    lowLength = low.toString().length;
    higthLength = high.toString().length;
    var result = [];
    for (let length = lowLength; length <= higthLength; ++length) {
        for (let firstNumber = 1; firstNumber <= 10 - length; ++firstNumber) {
            var value = makeNum(length, firstNumber);
            if(value <= high && value >= low){
                result.push(value);
            }
        }
    }
    return result;
};

console.log(sequentialDigits(100,300));     //[123,234]
console.log(sequentialDigits(1000,13000));  //[1234,2345,3456,4567,5678,6789,12345]