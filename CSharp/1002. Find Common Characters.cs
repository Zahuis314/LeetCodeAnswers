using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestCommonChars()
        {
            var result0 = CommonChars(new string[] { "bella", "label", "roller" }); // ["e","l","l"]
            var result1 = CommonChars(new string[] { "cool", "lock", "cook"});      // ["c","o"]
            var result2 = CommonChars(new string[] { "cool"});      // ["c","o"]
        }

        //Given a string array words, return an array of all characters that show up in all strings within the words(including duplicates). You may return the answer in any order.
        //1 <= words.length <= 100
        //1 <= words[i].length <= 100
        //words[i] consists of lowercase English letters.


        public IList<string> CommonChars(string[] words)
        {
            List<Dictionary<char, int>> charCountPerWords = new List<Dictionary<char, int>>();
            foreach (var word in words)
                charCountPerWords.Add(CommonCharsCountCharInWord(word));
            Dictionary<char, int> result = charCountPerWords[0];
            for (int i = 1; i < charCountPerWords.Count; i++)
                CommonCharsSetMinimunDictionary(result, charCountPerWords[i]);
            return 
                result
                .Aggregate("", (accum, item) => accum + new string(item.Key, item.Value))
                .Select(c => c.ToString())
                .ToList();
        }
        private Dictionary<char, int> CommonCharsCountCharInWord(string s)
        {
            var result = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (result.ContainsKey(c))
                    result[c]++;
                else
                    result.Add(c, 1);
            }
            return result;
        }
        private void CommonCharsSetMinimunDictionary(Dictionary<char, int> d1, Dictionary<char, int> d2)
        {
            foreach (var (key,value) in d1)
            {
                if (d2.ContainsKey(key))
                    d1[key] = Math.Min(value, d2[key]);
                else
                    d1.Remove(key);
            }
        }
    }
}
