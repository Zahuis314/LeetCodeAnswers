// Given two strings s and t, return true if they are equal when both are typed into empty text editors. '#' means a backspace character.
// Note that after backspacing an empty text, the text will continue empty.

// 1 <= s.length, t.length <= 200
// s and t only contain lowercase letters and '#' characters.

var reduceString = function(s) {
    var pointer = 0;
    while(pointer<s.length){
        if(s[pointer++]=='#'){
            var p1 = pointer==1 ? "":s.slice(0,pointer-2), p2 = s.slice(pointer);
            s = p1+p2;
            pointer-=2;
        }
    }
    return s;
}
/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
var backspaceCompare = function(s, t) {
    s = reduceString(s);
    t = reduceString(t);
    if(s.length!=t.length) return false;
    for (let i = 0; i < s.length; i++) {
        if(s[i]!=t[i]) return false;
    }
    return true;
};
console.log(backspaceCompare("ab#c", "ad#c")==true);
console.log(backspaceCompare("ab##", "c#d#")==true);
console.log(backspaceCompare("a#c", "b")==false);
console.log(backspaceCompare("ab", "ad")==false);
console.log(backspaceCompare("ab", "ab")==true);
console.log(backspaceCompare("b#c", "b#b")==false);
console.log(backspaceCompare("bc#", "bb#")==true);
console.log(backspaceCompare("a##c", "#a#c")==true);