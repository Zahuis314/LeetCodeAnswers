using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestMaxAreaOfIsland()
        {
            Console.WriteLine(MaxAreaOfIsland(new int[][] {
                new int[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 },
                new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 }
            }) == 6);
            Console.WriteLine(MaxAreaOfIsland(new int[][] { new int[] { 0, 0, 0, 0, 0, 0, 0, 0 } }) == 0);
        }
        //You are given an m x n binary matrix grid.An island is a group of 1's (representing land) connected 4-directionally (horizontal or vertical.) You may assume all four edges of the grid are surrounded by water.
        //The area of an island is the number of cells with a value 1 in the island.
        //Return the maximum area of an island in grid.If there is no island, return 0.

        //m == grid.length
        //n == grid[i].length
        //1 <= m, n <= 50
        //grid[i][j] is either 0 or 1.

        public int MaxAreaOfIsland(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            bool[,] visited = new bool[m, n];
            int[] directionX = new[] { 0, 0, 1, -1 };
            int[] directionY = new[] { -1, 1, 0, 0 };
            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
            int max = 0;
            for (int x_search = 0; x_search < m; x_search++)
            {
                for (int y_search = 0; y_search < n; y_search++)
                {
                    if (!visited[x_search, y_search] && grid[x_search][y_search] == 1)
                    {
                        visited[x_search, y_search] = true;
                        int current = 0;
                        queue.Enqueue(new Tuple<int, int>(x_search, y_search));
                        while (queue.Count > 0)
                        {
                            var (x, y) = queue.Dequeue();
                            current++;
                            for (int i = 0; i < 4; i++)
                            {
                                int new_x = x + directionX[i];
                                int new_y = y + directionY[i];
                                if (new_x >= 0 && new_x < m && new_y >= 0 && new_y < n &&
                                    !visited[new_x, new_y] && grid[new_x][new_y] == 1)
                                {
                                    queue.Enqueue(new Tuple<int, int>(new_x, new_y));
                                    visited[new_x, new_y] = true;
                                }
                            }
                        }
                        max = Math.Max(max, current);
                    }
                }
            }
            return max;
        }
    }
}
