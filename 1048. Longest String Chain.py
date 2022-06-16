from typing import List
 
# You are given an array of words where each word consists of lowercase English letters.
# wordA is a predecessor of wordB if and only if we can insert exactly one letter anywhere in wordA without changing the order of the other characters to make it equal to wordB.
# For example, "abc" is a predecessor of "abac", while "cba" is not a predecessor of "bcad".
# A word chain is a sequence of words [word1, word2, ..., wordk] with k >= 1, where word1 is a predecessor of word2, word2 is a predecessor of word3, and so on. A single word is trivially a word chain with k == 1.
# Return the length of the longest possible word chain with words chosen from the given list of words.

# 1 <= words.length <= 1000
# 1 <= words[i].length <= 16
# words[i] only consists of lowercase English letters.

class Solution:
    def longestStrChain(self, words: List[str]) -> int:
        def isPredecessor(shortWord: str, longWord: str) -> bool:
            if(len(shortWord) + 1 != len(longWord)):
                return False
            diff=0
            i=0
            while i<len(shortWord):
                if shortWord[i] != longWord[i+diff]:
                    if diff:
                        return False
                    diff = 1
                else:
                    i += 1
            return True
        words.sort(key=len)
        maxx = 1
        dp = [1]*len(words)
        for i in range(len(words)):
            for j in range(i):
                if isPredecessor(words[j],words[i]):
                    dp[i] = max(dp[i], dp[j]+1)
                    maxx = max(maxx, dp[i])
        return max(dp)

solver = Solution()
print(solver.longestStrChain(["xbc","pcxbcf","xb","cxbc","pcxbc"]))
print(solver.longestStrChain(["a","b","ba","bca","bda","bdca"]))
print(solver.longestStrChain(["abcd","dbqca"]))
print(solver.longestStrChain(["qyssedya","pabouk","mjwdrbqwp","vylodpmwp","nfyqeowa","pu","paboukc","qssedya","lopmw","nfyqowa","vlodpmw","mwdrqwp","opmw","qsda","neo","qyssedhyac","pmw","lodpmw","mjwdrqwp","eo","nfqwa","pabuk","nfyqwa","qssdya","qsdya","qyssedhya","pabu","nqwa","pabqoukc","pbu","mw","vlodpmwp","x","xr"]))