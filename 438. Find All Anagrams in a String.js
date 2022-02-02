// Given two strings s and p, return an array of all the start indices of p's anagrams in s. You may return the answer in any order.
// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
var _ = require('lodash');
// 1 <= s.length, p.length <= 3 * 10^4
// s and p consist of lowercase English letters.
var increaseDictionary = function(dict, value){
    if(_.has(dict,value)){
        dict[value] += 1;
    } else {
        dict[value] = 1; 
    }
}
var decreaseDictionary = function(dict, value){
    dict[value] -= 1;
    if(dict[value] == 0){
        delete dict[value];
    }
}
/**
 * @param {string} s
 * @param {string} p
 * @return {number[]}
 */
var findAnagrams = function(s, p) {
    if(s.length<p.length){return [];}
    else if(s.length==p.length){
        if(s.split('').sort().join('') == p.split('').sort().join('')){
            return [0];
        }else{
            return [];
        }
    }
    var set = {}, currentSet = {}, result = [];
    for (const c of p) {
        increaseDictionary(set,c)
    }
    var window = p.length;
    s = '1'.repeat(p.length) + s;
    currentSet['1'] = p.length;
    var shift = p.length - 1;
    for (var i = p.length; i < s.length; i++)
    {
        increaseDictionary(currentSet, s[i]);
        decreaseDictionary(currentSet, s[i - p.length]);
        if (!_.has(set,s[i]) || !_.has(currentSet,s[i])) {
            shift = p.length - 1;
        }else if (shift != 0){
            shift--;
        }else if (_.isEqual(currentSet, set)){
            result.push(i + 1 - p.length*2);
        }
      
    }
    return result;
};
console.log(findAnagrams("ab", "ab"));          // [0]
console.log(findAnagrams("ba", "ab"));          // [0]
console.log(findAnagrams("ac", "ab"));          // []
console.log(findAnagrams("eidbaooo", "aab"));   // []
console.log(findAnagrams("eidbaaoo", "aab"));   // [3]
console.log(findAnagrams("eidabaoo", "aab"));   // [3]
console.log(findAnagrams("eidaabaaoo", "aab")); // [3,4,5]
console.log(findAnagrams("eidboaoo", "ab"));    // []
console.log(findAnagrams("dcda", "adc"));       // [1]
console.log(findAnagrams("ab", "a"));           // [0]
console.log(findAnagrams("cbaebabacd", "abc")); // [0,6]
console.log(findAnagrams("abab", "ab"));        // [0,1,2]
console.log(findAnagrams("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdef",
"bcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefg")) // []