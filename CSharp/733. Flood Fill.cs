using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestFloodFill()
        {
            var test1 = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 } };
            var result1 = FloodFill(test1, 0, 0, 2); // [[2,2,2],[2,2,0],[2,0,1]]

            var test2 = new int[][] { new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 } };
            var result2= FloodFill(test2, 0, 0, 2); // [[2,2,2],[2,2,2]]
        }
        //An image is represented by an m x n integer grid image where image[i][j] represents the pixel value of the image.
        //You are also given three integers sr, sc, and newColor.You should perform a flood fill on the image starting from the pixel image[sr][sc].
        //To perform a flood fill, consider the starting pixel, plus any pixels connected 4-directionally to the starting pixel of the same color as the starting pixel, plus any pixels connected 4-directionally to those pixels (also with the same color), and so on.Replace the color of all of the aforementioned pixels with newColor.
        //Return the modified image after performing the flood fill.

        //m == image.length
        //n == image[i].length
        //1 <= m, n <= 50
        //0 <= image[i][j], newColor< 2^16
        //0 <= sr<m
        //0 <= sc<n

        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            int m = image.Length;
            int n = image[0].Length;
            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>(new[] { new Tuple<int, int>(sr, sc) });
            bool[,] visited = new bool[m, n];
            int originalPixel = image[sr][sc];
            int[] directionX = new[] { 0, 0, 1, -1 };
            int[] directionY = new[] { -1, 1, 0, 0 };

            while(queue.Count > 0)
            {
                var (x,y) = queue.Dequeue();
                if(image[x][y] == originalPixel)
                {
                    image[x][y] = newColor;
                    for (int i = 0; i < 4; i++)
                        if (x + directionX[i] >= 0 && x + directionX[i] < m &&
                            y + directionY[i] >= 0 && y + directionY[i] < n &&
                            !visited[x + directionX[i], y + directionY[i]])
                        {
                            queue.Enqueue(new Tuple<int, int>(x + directionX[i], y + directionY[i]));
                            visited[x + directionX[i], y + directionY[i]] = true;
                        }
                }
            }
            return image;
        }
    }
}
