using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestWordPattern()
        {
            Console.WriteLine(WordPattern("abba", "dog cat cat dog")==true);
            Console.WriteLine(WordPattern("abba", "dog cat cat fish")==false);
            Console.WriteLine(WordPattern("aaaa", "dog cat cat dog")==false);
            Console.WriteLine(WordPattern("aaa", "dog cat cat dog") == false);
            Console.WriteLine(WordPattern("aaa", "dog cat") == false);
            Console.WriteLine(WordPattern("abba", "dog dog dog dog") == false);
        }
        //Given a pattern and a string s, find if s follows the same pattern.
        //Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.

        //1 <= pattern.length <= 300
        //pattern contains only lower-case English letters.
        //1 <= s.length <= 3000
        //s contains only lowercase English letters and spaces ' '.
        //s does not contain any leading or trailing spaces.
        //All the words in s are separated by a single space.

        public bool WordPattern(string pattern, string s)
        {
            var splitted_s = s.Split(' ');
            if (pattern.Length != splitted_s.Length)
                return false;
            Dictionary<char, string> pattern_dict = new Dictionary<char, string>();
            for (int i = 0; i < splitted_s.Length; i++)
                if(!pattern_dict.ContainsKey(pattern[i]))
                    pattern_dict.Add(pattern[i], splitted_s[i]);
                else
                    if (pattern_dict[pattern[i]] != splitted_s[i])
                        return false;
            return pattern_dict.Values.ToHashSet().Count == pattern_dict.Values.Count;
        }
    }
}
