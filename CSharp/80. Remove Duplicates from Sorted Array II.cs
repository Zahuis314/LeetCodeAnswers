using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestRemoveDuplicates()
        {
            var test0 = new List<int>() { 0, 1, 2, 3, 3, 4, 4, 4, 5, 5, 5, 5, 6}.ToArray();
            var result0 = RemoveDuplicates(test0);  // 10 array=[0,1,2,3,3,4,4,5,5,6,_,_,_]
            
            var test1 = new List<int>() { 1, 1, 1, 2, 2, 3 }.ToArray();
            var result1 = RemoveDuplicates(test1);  // 5 array=[1,1,2,2,3,_]

            var test2 = new List<int>() { 0, 0, 1, 1, 1, 1, 2, 3, 3}.ToArray();
            var result2 = RemoveDuplicates(test2);  // 7 array=[0,0,1,1,2,3,3,_,_]

            var test3 = new List<int>() { 0, 0, 0 }.ToArray();
            var result3 = RemoveDuplicates(test3);  // 7 array=[0,0,_]
            Console.WriteLine();
        }
        //Given an integer array nums sorted in non-decreasing order, remove some duplicates in-place such that each unique element appears at most twice.The relative order of the elements should be kept the same.
        //Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums.More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result. It does not matter what you leave beyond the first k elements.
        //Return k after placing the final result in the first k slots of nums.
        //Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.

        //1 <= nums.length <= 3 * 10^4
        //-10^4 <= nums[i] <= 10^4
        //nums is sorted in non-decreasing order.

        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            else if (nums.Length < 3)
                return nums.Length;
            int slow = 1;
            for (int fast = 2; fast < nums.Length; fast++)
            {
                if (nums[fast] != nums[slow])
                    nums[++slow] = nums[fast];
                else if (nums[fast] == nums[slow] && nums[slow] != nums[slow - 1])
                    nums[++slow] = nums[fast];

            }
            return slow+1;
        }
    }
}
