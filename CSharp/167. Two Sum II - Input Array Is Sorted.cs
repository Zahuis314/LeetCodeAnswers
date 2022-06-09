using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestTwoSum()
        {
            Console.WriteLine(TwoSum(new int[] { 2, 7, 11, 15 }, 9));   //[1,2]
            Console.WriteLine(TwoSum(new int[] { 2, 3, 4 }, 6));   //[1,3]
            Console.WriteLine(TwoSum(new int[] { -1, 0 }, -1));   //[1,2]
        }
        //Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1<index2 <= numbers.length.
        //Return the indices of the two numbers, index1 and index2, added by one as an integer array[index1, index2] of length 2.
        //The tests are generated such that there is exactly one solution.You may not use the same element twice.
        //Your solution must use only constant extra space.

        //2 <= numbers.length <= 3 * 10^4
        //-1000 <= numbers[i] <= 1000
        //numbers is sorted in non-decreasing order.
        //-1000 <= target <= 1000
        //The tests are generated such that there is exactly one solution.
        public int[] TwoSum(int[] numbers, int target)
        {
            int left_index = 0, right_index = numbers.Length - 1;
            while (numbers[left_index] + numbers[right_index] != target)
            {
                if (numbers[left_index] + numbers[right_index] > target)
                    right_index--;
                else
                    left_index++;
            }
            return new int[] { left_index + 1, right_index + 1 };
        }
    }
}
