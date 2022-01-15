using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharp.Utils;

namespace CSharp
{
    public partial class Solution
    {
        public void TestMinJumps()
        {
            Console.WriteLine(MinJumps(new[] { 100, -23, -23, 404, 100, 23, 23, 23, 3, 404 }) == 3);
            Console.WriteLine(MinJumps(new[] { 7 }) == 0);
            Console.WriteLine(MinJumps(new[] { 7, 6, 9, 6, 9, 6, 9, 7 }) == 1);
            Console.WriteLine(MinJumps(new[] { 7, 1 }) == 1);
            Console.WriteLine(MinJumps(new[] { 7, 1, 7 }) == 1);
            Console.WriteLine(MinJumps(new[] { 7, 1, 7, 1 }) == 2);
            Console.WriteLine(MinJumps(new[] { 7, 1, 2, 3 }) == 3);
            var testCases = LoadTestCase<int,int>("1345.txt");
            foreach (var testCase in testCases)
            {
                Console.WriteLine(MinJumps(testCase.Item1.ToArray()) == testCase.Item2);
            }
        }
        //Given an array of integers arr, you are initially positioned at the first index of the array.
        //In one step you can jump from index i to index:
        //    i + 1 where: i + 1 < arr.length.
        //    i - 1 where: i - 1 >= 0.
        //    j where: arr[i] == arr[j] and i != j.
        //Return the minimum number of steps to reach the last index of the array.
        //Notice that you can not jump outside of the array at any time.

        //1 <= arr.length <= 5 * 10^4
        //-10^8 <= arr[i] <= 10^8

        private Dictionary<int, HashSet<int>> buildPossibleMinJumps(int[] arr)
        {
            Dictionary<int, HashSet<int>> same_number_indexes = new Dictionary<int, HashSet<int>>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!same_number_indexes.ContainsKey(arr[i]))
                    same_number_indexes[arr[i]] = new HashSet<int>();
                same_number_indexes[arr[i]].Add(i);
            }
            return same_number_indexes;
        }
        public int MinJumps(int[] arr)
        {
            Dictionary<int, HashSet<int>> possibles_jumps = buildPossibleMinJumps(arr);
            bool[] visited = new bool[arr.Length];
            Queue<(int, int)> queue = new Queue<(int, int)>(new[] { (Index: 0, Depth: 0) });
            visited[0] = true;
            while (queue.Count > 0)
            {
                var (index,depth) = queue.Dequeue();
                if (index == arr.Length - 1)
                    return depth;
                if (possibles_jumps.ContainsKey(arr[index]))
                {
                    foreach (var new_index in possibles_jumps[arr[index]])
                    {
                        if (!visited[new_index])
                        {
                            visited[new_index] = true;
                            queue.Enqueue((new_index, depth + 1));
                        }
                    }
                    possibles_jumps.Remove(arr[index]);
                }
                if (index > 1 && !visited[index - 1])
                {
                    visited[index-1] = true;
                    queue.Enqueue((index-1, depth + 1));
                }
                if (index != arr.Length - 1 && !visited[index + 1])
                {
                    visited[index + 1] = true;
                    queue.Enqueue((index + 1, depth + 1));
                }

            }
            return -1;
        }
    }
}
