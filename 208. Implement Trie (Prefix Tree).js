// A trie (pronounced as "try") or prefix tree is a tree data structure used to efficiently store and retrieve keys in a dataset of strings. There are various applications of this data structure, such as autocomplete and spellchecker.
// Implement the Trie class:
// Trie() Initializes the trie object.
// void insert(String word) Inserts the string word into the trie.
// boolean search(String word) Returns true if the string word is in the trie (i.e., was inserted before), and false otherwise.
// boolean startsWith(String prefix) Returns true if there is a previously inserted string word that has the prefix prefix, and false otherwise.

// 1 <= word.length, prefix.length <= 2000
// word and prefix consist only of lowercase English letters.
// At most 3 * 104 calls in total will be made to insert, search, and startsWith.


var Trie = function() {
    this.dictionary = {};
};

/** 
 * @param {string} word
 * @return {void}
 */
Trie.prototype.insert = function(word) {
    if(word.length>0){
        if(!this.dictionary[word[0]]){
            this.dictionary[word[0]] = new Trie();
        }
        this.dictionary[word[0]].insert(word.slice(1));
    } else {
        this.isEnd = true;
    }
};

/** 
 * @param {string} word
 * @return {Trie}
 */
Trie.prototype.getNode = function(prefix) {
    if(prefix.length==0){ return this; }
    var node = this.dictionary[prefix[0]];
    return node ? node.getNode(prefix.slice(1)) : null;
}

/** 
 * @param {string} word
 * @return {boolean}
 */
Trie.prototype.search = function(word) {
    var node = this.getNode(word);
    return node != null && node.isEnd === true;
};

/** 
 * @param {string} prefix
 * @return {boolean}
 */
Trie.prototype.startsWith = function(prefix) {
    var node = this.getNode(prefix);
    return node != null;
};


var trie = new Trie()
trie.insert("apple");
console.log(trie.search("apple"));   // return True
console.log(trie.search("app"));     // return False
console.log(trie.startsWith("app")); // return True
trie.insert("app");
console.log(trie.search("app"));     // return True