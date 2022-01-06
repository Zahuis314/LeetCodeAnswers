using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestLongestCommonPrefix()
        {
            Console.WriteLine(LongestCommonPrefix(
                new List<string>() { "flower", "flow", "flight" }.ToArray())); // "fl"
            Console.WriteLine(LongestCommonPrefix(
                new List<string>() { "" }.ToArray())); // ""
            Console.WriteLine(LongestCommonPrefix(
                new List<string>() { "a" }.ToArray())); // "a"
            Console.WriteLine(LongestCommonPrefix(
                new List<string>() { "dog", "racecar", "car" }.ToArray())); // ""
            Console.WriteLine(LongestCommonPrefix(
                new List<string>() { "cir", "car" }.ToArray())); // "c"
            Console.WriteLine(LongestCommonPrefix(
                new List<string>() { "reflower", "flow", "flight" }.ToArray())); // ""
        }
        //Write a function to find the longest common prefix string amongst an array of strings.
        //If there is no common prefix, return an empty string "".

        //1 <= strs.length <= 200
        //0 <= strs[i].length <= 200
        //strs[i] consists of only lower-case English letters.
        
        public string LongestCommonPrefix(string[] strs)
        {
            string s = strs[0];
            foreach (var str in strs)
            {
                if (str.Length < s.Length)
                    s = str;
            }
            if (s.Length == 0)
                return s;
            string LGP = LongestCommonPrefix(strs, s);
            return LGP;
        }
        private string LongestCommonPrefix(string[] strs, string s)
        {
            if (s.Length == 0)
                return s;
            bool allContains = strs.All(str => str.StartsWith(s));
            return allContains ? s : LongestCommonPrefix(strs, s[0..^1]);
        }
    }
}
