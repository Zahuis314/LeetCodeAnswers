using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution { 
    
        public void TestNumMatrixSumRegion()
        {
            var matrix1 = new int[][]
            {
                new int[]{ 3, 0, 1, 4, 2 },
                new int[]{ 5, 6, 3, 2, 1 },
                new int[]{ 1, 2, 0, 1, 5 },
                new int[]{ 4, 1, 0, 1, 7 },
                new int[]{ 1, 0, 3, 0, 5 }
            };
            var test1 = new NumMatrix(matrix1);

            Console.WriteLine(test1.SumRegion(2, 1, 4, 3)==8);
            Console.WriteLine(test1.SumRegion(1, 1, 2, 2)==11);
            Console.WriteLine(test1.SumRegion(1, 2, 2, 4)==12);
        }
        //Given a 2D matrix matrix, handle multiple queries of the following type:
        //Calculate the sum of the elements of matrix inside the rectangle defined by its upper left corner(row1, col1) and lower right corner(row2, col2).
        //Implement the NumMatrix class:
        //NumMatrix(int[][] matrix) Initializes the object with the integer matrix matrix.
        //int sumRegion(int row1, int col1, int row2, int col2) Returns the sum of the elements of matrix inside the rectangle defined by its upper left corner(row1, col1) and lower right corner(row2, col2).
        //m == matrix.length
        //n == matrix[i].length
        //1 <= m, n <= 200
        //- 10^4 <= matrix[i][j] <= 10^4
        //0 <= row1 <= row2 < m
        //0 <= col1 <= col2 < n
        //At most 10^4 calls will be made to sumRegion.

        public class NumMatrix
        {
            int[][] memo;
            public NumMatrix(int[][] matrix)
            {
                memo = new int[matrix.Length][];
                Action<int, int[]> action = (row, func) => {
                    int acum = 0;
                    for (int i = 0; i < matrix[row].Length; i++)
                    {
                        acum += matrix[row][i];                     //acum of the row
                        memo[row][i] = acum + (func != null ? func[i] : 0);       //acum of the row plus same index of the previous column
                    }
                };
                int[] previousRow = null;
                for (int i = 0; i < matrix.Length; i++)
                {
                    memo[i] = new int[matrix[i].Length];
                    action(i, previousRow);
                    previousRow = memo[i];
                }
            }
            public int SumRegion(int row1, int col1, int row2, int col2)
            {
                return memo[row2][col2] - (col1 > 0 ? memo[row2][col1 - 1] : 0) - (row1 > 0 ? memo[row1 - 1][col2] : 0) + (col1 > 0 && row1 > 0 ? memo[row1 - 1][col1 - 1] : 0);
            }
        }
    }
}
