using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestReverseBits()
        {
            Console.WriteLine(reverseBits(43261596)== 964176192); 
            Console.WriteLine(reverseBits(4294967293) == 3221225471); 
        }
        //Reverse bits of a given 32 bits unsigned integer.Note:
        //Note that in some languages, such as Java, there is no unsigned integer type.In this case, both input and output will be given as a signed integer type. They should not affect your implementation, as the integer's internal binary representation is the same, whether it is signed or unsigned.
        //In Java, the compiler represents the signed integers using 2's complement notation. Therefore, in Example 2 above, the input represents the signed integer -3 and the output represents the signed integer -1073741825.
        //The input must be a binary string of length 32

        public uint reverseBits(uint n)
        {
            uint result = 0;
            for (int i = 0; i < 32; i++)
            {
                result = (result << 1) | (n & 1);
                n >>= 1;
            }
            return result;
        }
    }
}
