using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestRelativeSortArray()
        {
            var result1 = RelativeSortArray(
                new int[11] {2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19},
                new int[6] { 2, 1, 4, 3, 9, 6 });   // [2,2,2,1,4,3,3,9,6,7,19]
            var result2 = RelativeSortArray(
                new int[6] {28, 6, 22, 8, 44, 17},
                new int[4] { 22, 28, 8, 6 });   // [22,28,8,6,17,44]
        }
        //Given two arrays arr1 and arr2, the elements of arr2 are distinct, and all elements in arr2 are also in arr1.
        //Sort the elements of arr1 such that the relative ordering of items in arr1 are the same as in arr2.Elements that do not appear in arr2 should be placed at the end of arr1 in ascending order.

        //1 <= arr1.length, arr2.length <= 1000
        //0 <= arr1[i], arr2[i] <= 1000
        //All the elements of arr2 are distinct.
        //Each arr2[i] is in arr1.

        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            var result = new List<int>();

            var positions = new Dictionary<int, int>();
            var count = new int[arr2.Length];
            for (int i = 0; i < arr2.Length; i++)
            {
                positions[arr2[i]] = i;             // Here I save the position of a number in arr2
                count[i] = 0;                       // And the count to count it later from arr2
            }
            var unsorted = new List<int>();
            foreach (var number in arr1)
            {
                if (positions.ContainsKey(number))      // If element in arr1 is in arr2 
                    count[positions[number]]++;         // Increment count to append it later
                else
                    unsorted.Add(number);            // Else add to unsorted to sort later
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                var repetitions = count[i];
                for (int j = 0; j < repetitions; j++)
                    result.Add(arr2[i]);
            }

            unsorted.Sort();
            result.AddRange(unsorted);
            return result.ToArray();
        }
    }
}
