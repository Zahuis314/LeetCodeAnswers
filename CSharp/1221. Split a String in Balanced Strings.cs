using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestBalancedStringSplit()
        {
            Console.WriteLine(BalancedStringSplit("RLRRLLRLRL"));   // 4 
            Console.WriteLine(BalancedStringSplit("RLLLLRRRLR"));   // 3
            Console.WriteLine(BalancedStringSplit("LLLLRRRR"));   // 1
        }
        //Balanced strings are those that have an equal quantity of 'L' and 'R' characters.
        //Given a balanced string s, split it in the maximum amount of balanced strings.
        //Return the maximum amount of split balanced strings.

        //1 <= s.length <= 1000
        //s[i] is either 'L' or 'R'.
        //s is a balanced string.

        public int BalancedStringSplit(string s)
        {
            int result = 0;
            int count = 0;
            foreach (char c in s)
            {
                if (c == 'L')
                    count++;
                else
                    count--;
                if (count == 0)
                    result++;
            }
            return result;
        }
    }
}
