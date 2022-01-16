using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestMaxDistToClosest()
        {
            Console.WriteLine(MaxDistToClosest(new[] { 1, 0, 0, 0, 1, 0, 1 })==2);
            Console.WriteLine(MaxDistToClosest(new[] { 1, 0, 0, 0 })==3);
            Console.WriteLine(MaxDistToClosest(new[] { 0, 1 })==1);
        }
        //You are given an array representing a row of seats where seats[i] = 1 represents a person sitting in the ith seat, and seats[i] = 0 represents that the ith seat is empty(0-indexed).

        //There is at least one empty seat, and at least one person sitting.
        //Alex wants to sit in the seat such that the distance between him and the closest person to him is maximized.
        //Return that maximum distance to the closest person.

        //2 <= seats.length <= 2 * 10^4
        //seats[i] is 0 or 1.
        //At least one seat is empty.
        //At least one seat is occupied.
        public int MaxDistToClosest(int[] seats)
        {
            int max = 0;
            seats[0] = (seats[0] == 0) ? seats.Length : 0;
            for (int i = 1; i < seats.Length; i++)
                seats[i] = Math.Min( seats[i]==0 ? int.MaxValue : 0, seats[i-1]+1);
            for (int i = seats.Length - 2; i >= 0; i--)
            {
                seats[i] = Math.Min(seats[i], seats[i + 1] + 1);
                max = Math.Max(seats[i], max);
            }
            max = Math.Max(seats[^1], max);
            return max;
        }
    }
}
