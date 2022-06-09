using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestAreAlmostEqual()
        {
            Console.WriteLine(AreAlmostEqual("bank", "kanb")==true);
            Console.WriteLine(AreAlmostEqual("attack", "defend") ==false);
            Console.WriteLine(AreAlmostEqual("kelb", "kelb") ==true);
        }
        //You are given two strings s1 and s2 of equal length.A string swap is an operation where you choose two indices in a string (not necessarily different) and swap the characters at these indices.
        //Return true if it is possible to make both strings equal by performing at most one string swap on exactly one of the strings.Otherwise, return false.

        //1 <= s1.length, s2.length <= 100
        //s1.length == s2.length
        //s1 and s2 consist of only lowercase English letters.
        public bool AreAlmostEqual(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;
            int difference = 0;
            List<int> diffIndex = new List<int>();
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    difference++;
                    diffIndex.Add(i);
                }
                if (difference > 2)
                    return false;
            }
            if (diffIndex.Count == 0)
                return true;
            if (diffIndex.Count != 2 || s1[diffIndex[0]] != s2[diffIndex[1]] || s1[diffIndex[1]] != s2[diffIndex[0]])
                return false;
            return true;
        }
    }
}
