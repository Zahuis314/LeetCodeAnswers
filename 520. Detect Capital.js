// We define the usage of capitals in a word to be right when one of the following cases holds:
//     All letters in this word are capitals, like "USA".
//     All letters in this word are not capitals, like "leetcode".
//     Only the first letter in this word is capital, like "Google".
// Given a string word, return true if the usage of capitals in it is right.

// 1 <= word.length <= 100
// word consists of lowercase and uppercase English letters.

/**
 * @param {string} word
 * @return {boolean}
 */
var detectCapitalUse = function(word) {
    var length = word.length;
    var upper = 0, lower = 0;
    var firstIsUpper = /[A-Z]/.test(word[0]);
    for (let i = 0; i < length; i++)
        if (/[A-Z]/.test(word[i])){upper++;}
        else {lower++;}
    return ((firstIsUpper && lower==length-1) || lower==length || upper==length);
};

console.log(detectCapitalUse("USA")==true);
console.log(detectCapitalUse("USAa")==false);
console.log(detectCapitalUse("FlaG")==false);
console.log(detectCapitalUse("U")==true);
console.log(detectCapitalUse("u")==true);
console.log(detectCapitalUse("u")==true);
console.log(detectCapitalUse("uasd")==true);
console.log(detectCapitalUse("uasD")==false);
console.log(detectCapitalUse("Google")==true);
console.log(detectCapitalUse("GooglE")==false);