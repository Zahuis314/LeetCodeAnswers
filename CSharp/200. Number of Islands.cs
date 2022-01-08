using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestNumIslands()
        {
            Console.WriteLine(NumIslands(new char[][] {
                new char[] { '0', '0', '1', '0', '0', '0', '0', '1', '0', '0', '0', '0', '0' },
                new char[] { '0', '0', '0', '0', '0', '0', '0', '1', '1', '1', '0', '0', '0' },
                new char[] { '0', '1', '1', '0', '1', '0', '0', '0', '0', '0', '0', '0', '0' },
                new char[] { '0', '1', '0', '0', '1', '1', '0', '0', '1', '0', '1', '0', '0' },
                new char[] { '0', '1', '0', '0', '1', '1', '0', '0', '1', '1', '1', '0', '0' },
                new char[] { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '1', '0', '0' },
                new char[] { '0', '0', '0', '0', '0', '0', '0', '1', '1', '1', '0', '0', '0' },
                new char[] { '0', '0', '0', '0', '0', '0', '0', '1', '1', '0', '0', '0', '0' }
            }) == 6);
            Console.WriteLine(NumIslands(new char[][] { new char[] { '0', '0', '0', '0', '0', '0', '0', '0' } }) == 0);
            Console.WriteLine(NumIslands(new char[][] {
            new char[] { '1', '1', '1', '1', '0' },
            new char[] { '1', '1', '0', '1', '0' },
            new char[] { '1', '1', '0', '0', '0' },
            new char[] { '0', '0', '0', '0', '0' }
            }) == 1);
            Console.WriteLine(NumIslands(new char[][] {
            new char[] { '1', '1', '0', '0', '0' },
            new char[] { '1', '1', '0', '0', '0' },
            new char[] { '0', '0', '1', '0', '0' },
            new char[] { '0', '0', '0', '1', '1' }
            }) == 3);
        }
        //Given an m x n 2D binary grid grid which represents a map of '1's(land) and '0's(water), return the number of islands.
        //An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

        //m == grid.length
        //n == grid[i].length
        //1 <= m, n <= 300
        //grid[i][j] is '0' or '1'.


        public int NumIslands(char[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            bool[,] visited = new bool[m, n];
            int[] directionX = new[] { 0, 0, 1, -1 };
            int[] directionY = new[] { -1, 1, 0, 0 };
            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
            int islands = 0;
            for (int x_search = 0; x_search < m; x_search++)
            {
                for (int y_search = 0; y_search < n; y_search++)
                {
                    if (!visited[x_search, y_search] && grid[x_search][y_search] == '1')
                    {
                        visited[x_search, y_search] = true;
                        islands++;
                        queue.Enqueue(new Tuple<int, int>(x_search, y_search));
                        while (queue.Count > 0)
                        {
                            var (x, y) = queue.Dequeue();
                            for (int i = 0; i < 4; i++)
                            {
                                int new_x = x + directionX[i];
                                int new_y = y + directionY[i];
                                if (new_x >= 0 && new_x < m && new_y >= 0 && new_y < n &&
                                    !visited[new_x, new_y] && grid[new_x][new_y] == '1')
                                {
                                    queue.Enqueue(new Tuple<int, int>(new_x, new_y));
                                    visited[new_x, new_y] = true;
                                }
                            }
                        }
                    }
                }
            }
            return islands;
        }
    }
}
