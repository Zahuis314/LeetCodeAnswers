using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestMerge()
        {
            var test1array = new int[] { 1, 2, 3, 0, 0, 0 };
            Merge(test1array, 3, new int[] { 2, 5, 6 }, 3); // test1array = [1,2,2,3,5,6]

            var test2array = new int[] { 1 };
            Merge(test1array, 1, new int[] { }, 0); // test2array = [1]

            var test3array = new int[] { 0 };
            Merge(test3array, 0, new int[] { 1 }, 1); // test3array = [1]

        }
        //You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
        //Merge nums1 and nums2 into a single array sorted in non-decreasing order.
        //The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

        //nums1.length == m + n
        //nums2.length == n
        //0 <= m, n <= 200
        //1 <= m + n <= 200
        //-10^9 <= nums1[i], nums2[j] <= 10^9

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int curr = m + n - 1;
            m--;
            n--;
            while (m >= 0 && n >= 0)
                nums1[curr--] = (nums1[m] > nums2[n]) ? nums1[m--] : nums2[n--];
            while (n >= 0)
                nums1[curr--] = nums2[n--];
        }
    }
}
