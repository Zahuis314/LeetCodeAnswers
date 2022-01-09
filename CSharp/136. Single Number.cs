using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestSingleNumber(){
            Console.WriteLine(SingleNumber(new[] { 2, 2, 1 }) == 1);
            Console.WriteLine(SingleNumber(new[] { 4, 1, 2, 1, 2 }) == 4);
            Console.WriteLine(SingleNumber(new[] { 1 }) == 1);
        }
        //Given a non-empty array of integers nums, every element appears twice except for one.Find that single one.
        //You must implement a solution with a linear runtime complexity and use only constant extra space.
            
        //1 <= nums.length <= 3 * 10^4
        //-3 * 10^4 <= nums[i] <= 3 * 10^4
        //Each element in the array appears twice except for one element which appears only once.

        public int SingleNumber(int[] nums)
        {
            int result = nums[0];
            for (int i = 1; i < nums.Length; i++)
                result ^= nums[i];
            return result;
        }
}
}
