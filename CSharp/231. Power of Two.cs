using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestIsPowerOfTwo()
        {
            Console.WriteLine(IsPowerOfTwo(16) == true);
            Console.WriteLine(IsPowerOfTwo(1)==true);
            Console.WriteLine(IsPowerOfTwo(3) == false);
            Console.WriteLine(IsPowerOfTwo(7) == false);
        }
        //Given an integer n, return true if it is a power of two.Otherwise, return false.
        //An integer n is a power of two, if there exists an integer x such that n == 2x.

        //-2^31 <= n <= 2^31 - 1
        public bool IsPowerOfTwo(int n)
        {
            //return n > 0 && (n & (n - 1)) == 0;
            if (n <= 0)
                return false;
            bool hasOne = false;
            while (n != 1)
            {
                if (n % 2 == 1)
                    if (hasOne)
                        return false;
                    else
                        hasOne = true;
                n >>= 1;
            }
            return !hasOne;
        }
    }
}
