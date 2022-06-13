using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestMinimumTotal()
        {
            Console.WriteLine(MinimumTotal(
                new List<IList<int>>()
                {
                    new List<int>(){ 2 },
                    new List<int>() { 3, 4 },
                    new List<int>() { 6, 5, 7 },
                    new List<int>() { 4, 1, 8, 3 }
                })==11);
        }
        //Given a triangle array, return the minimum path sum from top to bottom.
        //For each step, you may move to an adjacent number of the row below.More formally, if you are on index i on the current row, you may move to either index i or index i + 1 on the next row.

        //1 <= triangle.length <= 200
        //triangle[0].length == 1
        //triangle[i].length == triangle[i - 1].length + 1
        //-10^4 <= triangle[i][j] <= 10^4
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            var dp = new List<List<int>>();
            dp.Add(new List<int>() { triangle[0][0] });
            for (int i = 1; i < triangle.Count; i++)
            {
                var row = new List<int>();
                for (int j = 0; j < triangle[i].Count; j++)
                {
                    var value = triangle[i][j];
                    if (j < triangle[i].Count - 1)
                    {
                        if (j > 0)
                            row.Add(value + Math.Min(dp[i - 1][j - 1], dp[i - 1][j]));
                        else
                            row.Add(value + dp[i - 1][j]);
                    }
                    else
                        row.Add(value + dp[i - 1][j - 1]);
                }
                dp.Add(row);
            }
            return dp[dp.Count - 1].Min();
        }
    }
}
