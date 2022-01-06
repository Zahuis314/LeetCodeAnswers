using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void GeneratePascalTriangle()
        {
            var result0 = GeneratePascalTriangle(1);   // [[1]]
            var result1 = GeneratePascalTriangle(5);   // [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
            var result2 = GeneratePascalTriangle(15);
            var result3 = GeneratePascalTriangle(30);
            Console.WriteLine();
        }
        //Given an integer numRows, return the first numRows of Pascal's triangle.
        //In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

        //1 <= numRows <= 30

        public IList<IList<int>> GeneratePascalTriangle(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            result.Add(new List<int>() {1});
            for (int i = 1; i < numRows; i++)
            {
                List<int> row = new List<int>() {1};
                for (int j = 1; j < i; j++)
                    row.Add(result[i-1][j-1]+ result[i - 1][j]);
                row.Add(1);
                result.Add(row);
            }
            return result;
        }
        public IList<IList<int>> GeneratePascalTriangleII(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            
            for (int i = 0; i < numRows; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j <= i; j++)
                    row.Add((int)Combination(i, j));
                result.Add(row);
            }
            return result;
        }
        private long Combination(int n, int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }
        private long Factorial(int n)
        {
            long result = 1;
            for (int i = n; i > 0; i--)
                result *= i;
            return result;
        }
    }
}
