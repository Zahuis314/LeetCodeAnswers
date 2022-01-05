using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestPartition()
        {
            var result1 = Partition("aab"); // [["a","a","b"],["aa","b"]]
            var result2 = Partition("a");   // [["a"]]
        }
        //Given a string s, partition s such that every substring of the partition is a palindrome.Return all possible palindrome partitioning of s.
        //A palindrome string is a string that reads the same backward as forward.

        //1 <= s.length <= 16
        //s contains only lowercase English letters.
        public IList<IList<string>> Partition(string s)
        {
            IList<IList<string>> result = new List<IList<string>>();
            Partition(result, new List<string>(), s, 0);
            return result;
        }
        private void Partition(IList<IList<string>> result, IList<string> cur, string s, int i)
        {
            if (i == s.Length)
                result.Add(cur.ToList());
            else
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (isPalindrome(s.Substring(i , j - i+1)))
                    {
                        cur.Add(s.Substring(i, j - i+1));
                        Partition(result, cur, s, j + 1);
                        cur.RemoveAt(cur.Count - 1);
                    }
                }
            }
        }
        bool isPalindrome(string s)
        {
            for (int i = 0; i < s.Length/2; i++)
                if(s[i] != s[s.Length-i-1])
                    return false;
            return true;
        }    
    }
}
