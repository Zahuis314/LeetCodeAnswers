using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestLengthOfLongestSubstring()
        {
            Console.WriteLine(LengthOfLongestSubstring("abcabcbb")==3);
            Console.WriteLine(LengthOfLongestSubstring("bbbbb") == 1);
            Console.WriteLine(LengthOfLongestSubstring("pwwkew") == 3);
            Console.WriteLine(LengthOfLongestSubstring("") == 0);
            Console.WriteLine(LengthOfLongestSubstring("a") == 1);
            Console.WriteLine(LengthOfLongestSubstring("abcd") == 4);
            Console.WriteLine(LengthOfLongestSubstring("abca") == 3);
            Console.WriteLine(LengthOfLongestSubstring("abacca") == 3);
        }
        //Given a string s, find the length of the longest substring without repeating characters.

        //0 <= s.length <= 5 * 10^4
        //s consists of English letters, digits, symbols and spaces.

        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length < 1)
                return s.Length;
            int init = 0;
            int window = 1;
            Queue<char> queue = new Queue<char>();
            queue.Enqueue(s[0]);
            Dictionary<char,int> set = new Dictionary<char, int>();
            set.Add(s[0],1);
            while (init+window<s.Length)
            {
                while (init + window < s.Length && !set.ContainsKey(s[init+window]))
                {
                    set.Add(s[init + window],1);
                    queue.Enqueue(s[init + window]);
                    window++;
                }
                do
                {
                    if (init + window < s.Length)
                    {
                        if (set[queue.Peek()] == 1)
                            set.Remove(queue.Dequeue());
                        else
                            set[queue.Dequeue()] -= 1;
                        if (set.ContainsKey(s[init + window]))
                            set[s[init + window]] += 1;
                        else
                            set.Add(s[init + window], 1);
                        queue.Enqueue(s[init + window]);
                        init++;
                    }
                } while (set.Any(item => item.Value > 1) && init + window < s.Length);
            }
            return window;
        }
    }
}
