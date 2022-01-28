// Design a data structure that supports adding new words and finding if a string matches any previously added string.
// Implement the WordDictionary class:
// WordDictionary() Initializes the object.
// void addWord(word) Adds word to the data structure, it can be matched later.
// bool search(word) Returns true if there is any string in the data structure that matches word or false otherwise. word may contain dots '.' where dots can be matched with any letter.
 
// 1 <= word.length <= 500
// word in addWord consists lower-case English letters.
// word in search consist of  '.' or lower-case English letters.
// At most 50000 calls will be made to addWord and search.


var WordDictionary = function() {
    this.dictionary = {};
};

/** 
 * @param {string} word
 * @return {void}
 */
WordDictionary.prototype.addWord = function(word) {
    if(word.length>0){
        if(!this.dictionary[word[0]]){
            this.dictionary[word[0]] = new WordDictionary();
        }
        this.dictionary[word[0]].addWord(word.slice(1));
    } else {
        this.isEnd = true;
    }
};

/** 
 * @param {string} word
 * @return {boolean}
 */
WordDictionary.prototype.search = function(word) {
    if(word.length==0 && this.isEnd === true){
        return true;
    }
    if(word[0] != '.'){
        if(this.dictionary[word[0]]){
            return this.dictionary[word[0]].search(word.slice(1))
        }
        else{
            return false;
        }
    }else{
        for (let char in this.dictionary) {
            if (this.dictionary[char].search(word.slice(1))){ return true; }
        }
        return false;
    }

};

var wordDictionary = new WordDictionary();
wordDictionary.addWord("bad");
wordDictionary.addWord("dad");
wordDictionary.addWord("mad");
console.log(wordDictionary.search("pad")); // return False
console.log(wordDictionary.search("bad")); // return True
console.log(wordDictionary.search(".ad")); // return True
console.log(wordDictionary.search("b..")); // return True