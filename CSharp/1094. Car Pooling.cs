using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestCarPooling()
        {
            var test0 = new int[][] { new int[3] { 2, 1, 5 }, new int[3] { 3, 5, 7 } };
            Console.WriteLine(CarPooling(test0, 3) == true);
            var test1 = new int[][] { new int[3]{ 2, 1, 5 }, new int[3]{ 3, 3, 7 } };
            Console.WriteLine(CarPooling(test1, 4)==false);
            var test2 = new int[][] { new int[3] { 2, 1, 5 }, new int[3] { 3, 3, 7 } };
            Console.WriteLine(CarPooling(test2, 5)==true);
            var test3 = new int[][] { new int[3] { 4, 5, 6 },
                new int[3] { 6, 4, 7 },
                new int[3] { 4, 3, 5 },
                new int[3] { 2, 3, 5 }};
            Console.WriteLine(CarPooling(test3, 13) == true);

        }
        //There is a car with capacity empty seats.The vehicle only drives east (i.e., it cannot turn around and drive west).
        //You are given the integer capacity and an array trips where trip[i] = [numPassengersi, fromi, toi] indicates that the ith trip has numPassengersi passengers and the locations to pick them up and drop them off are fromi and toi respectively.The locations are given as the number of kilometers due east from the car's initial location.
        //Return true if it is possible to pick up and drop off all passengers for all the given trips, or false otherwise.

        //1 <= trips.length <= 1000
        //trips[i].length == 3
        //1 <= numPassengersi <= 100
        //0 <= fromi<toi <= 1000
        //1 <= capacity <= 10^5
        public bool CarPooling(int[][] trips, int capacity)
        {
            var tripsList = new List<Tuple<int,int>>();

            foreach (var trip in trips)
            {
                tripsList.Add(new Tuple<int, int>(trip[1], -trip[0]));
                tripsList.Add(new Tuple<int, int>(trip[2], trip[0]));
            }
            tripsList.Sort(
                (t1,t2) => t1.Item1.Equals(t2.Item1)
                        ? t2.Item2.CompareTo(t1.Item2)
                        : t1.Item1.CompareTo(t2.Item1));
            int currentCapacity = capacity;
            foreach (var trip in tripsList)
            {
                currentCapacity += trip.Item2;
                if (currentCapacity < 0 || currentCapacity > capacity)
                    return false;
            }
            return true;
        }
    }
}
