using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestCheckInclusion()
        {
            Console.WriteLine(CheckInclusion("ab", "ab") == true);
            Console.WriteLine(CheckInclusion("ab", "ac") == false);
            Console.WriteLine(CheckInclusion("ab", "eidbaooo") == true);
            Console.WriteLine(CheckInclusion("ab", "eidboaoo") == false);
            Console.WriteLine(CheckInclusion("adc", "dcda") == true);
            Console.WriteLine(CheckInclusion("a", "ab") == true);
            Console.WriteLine(CheckInclusion("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdef", "bcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefg") == false);
            

        }
        //Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.
        //In other words, return true if one of s1's permutations is the substring of s2.

        //1 <= s1.length, s2.length <= 10^4
        //s1 and s2 consist of lowercase English letters.


        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;
            else if (s1.Length == s2.Length)
            {
                var a = s1.ToList();
                var b = s2.ToList();
                a.Sort();
                b.Sort();
                return a.SequenceEqual(b);
            }
            Dictionary<char, int> set = new Dictionary<char, int>();
            foreach (var c in s1)
            {
                if (set.ContainsKey(c))
                    set[c] += 1;
                else
                    set.Add(c, 1);
            }
            int window = s1.Length;
            s2 = new string('1',s1.Length) + s2;
            Dictionary<char, int> currentSet = new Dictionary<char, int>();
            currentSet.Add('1', s1.Length);
            int shift = s1.Length - 1;
            for (int i = s1.Length; i < s2.Length; i++)
            {
                Utils.IncreaseDictionary(currentSet, s2[i]);
                Utils.DecreaseToDictionary(currentSet, s2[i - s1.Length]);
                if (!set.ContainsKey(s2[i]) || !currentSet.ContainsKey(s2[i])) {
                    shift = s1.Length - 1;
                    continue;
                }
                if (shift != 0)
                {
                    shift--;
                    continue;
                }
                if (currentSet.OrderBy(r => r.Key).SequenceEqual(set.OrderBy(r => r.Key)))
                    return true;
            }
            return false;
        }
    }
}
