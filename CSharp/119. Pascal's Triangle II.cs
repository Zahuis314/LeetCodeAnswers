using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestGeneratePascalTriangleRow()
        {
            var result0 = GeneratePascalTriangleRow(0);   // [1]
            var result1 = GeneratePascalTriangleRow(1);   // [1,1]
            var result2 = GeneratePascalTriangleRow(2);   // [1,2,1]
            var result3 = GeneratePascalTriangleRow(3);   // [1,3,3,1]
            var result4 = GeneratePascalTriangleRow(4);   // [1,4,6,4,1]
            var result14 = GeneratePascalTriangleRow(14);
            var result24 = GeneratePascalTriangleRow(24);
            var result29 = GeneratePascalTriangleRow(29);
            Console.WriteLine();
        }
        //Given an integer rowIndex, return the rowIndexth(0-indexed) row of the Pascal's triangle.
        //In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

        //0 <= numRows <= 33

        public IList<int> GeneratePascalTriangleRow(int rowIndex)
        {
            if (rowIndex == 0)
                return new List<int>() { 1 };
            IList<int> result = new List<int>() { 1, 1 };
            for (int i = 1; i < rowIndex; i++)
            {
                int previous = 1;
                for (int j = 1; j <= i; j++)
                {
                    int temp = result[j];
                    result[j] = result[j] + previous;
                    previous = temp;
                }
                result.Add(1);
            }
            return result;
        }
    }
}
