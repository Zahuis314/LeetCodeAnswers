using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestMinEatingSpeed()
        {
            Console.WriteLine(MinEatingSpeed(new[] { 3, 6, 7, 11 }, 8)==4);
            Console.WriteLine(MinEatingSpeed(new[] { 2, 4}, 3)==2);
            Console.WriteLine(MinEatingSpeed(new[] { 3, 4}, 3)==3);
            Console.WriteLine(MinEatingSpeed(new[] { 3, 4}, 2)==4);
            Console.WriteLine(MinEatingSpeed(new[] { 30, 11, 23, 4, 20 }, 5)==30);
            Console.WriteLine(MinEatingSpeed(new[] { 30, 11, 23, 4, 20 }, 6)==23);
            Console.WriteLine(MinEatingSpeed(new[] { 312884470 }, 968709470)==1);
        }
        //Koko loves to eat bananas.There are n piles of bananas, the ith pile has piles[i] bananas.The guards have gone and will come back in h hours.
        //Koko can decide her bananas-per-hour eating speed of k.Each hour, she chooses some pile of bananas and eats k bananas from that pile.If the pile has less than k bananas, she eats all of them instead and will not eat any more bananas during this hour.
        //Koko likes to eat slowly but still wants to finish eating all the bananas before the guards return.
        //Return the minimum integer k such that she can eat all the bananas within h hours.

        //1 <= piles.length <= 10^4
        //piles.length <= h <= 10^9
        //1 <= piles[i] <= 10^9

        public int MinEatingSpeed(int[] piles, int h)
        {
            int left = 1, right = piles.Max();
            while (left <= right){
                int middle = (left + right + 1) / 2;
                if (piles.Aggregate(0,(acum,pile)=>acum+((pile - 1) / middle + 1))<=h)
                    right = middle - 1;
                else
                    left = middle + 1;
            }
            return left;
        }
    }
}
