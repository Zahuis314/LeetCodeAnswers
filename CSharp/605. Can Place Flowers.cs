using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestCanPlaceFlowers()
        {
            Console.WriteLine(CanPlaceFlowers(new[] { 1, 0, 0, 0, 1 }, 1) == true);
            Console.WriteLine(CanPlaceFlowers(new[] { 1, 0, 0, 0, 1 }, 2) == false);
            Console.WriteLine(CanPlaceFlowers(new[] { 1 }, 0) == true);
            Console.WriteLine(CanPlaceFlowers(new[] { 1 }, 1) == false);
            Console.WriteLine(CanPlaceFlowers(new[] { 1, 0 }, 0) == true);
            Console.WriteLine(CanPlaceFlowers(new[] { 1, 0 }, 1) == false);
            Console.WriteLine(CanPlaceFlowers(new[] { 0, 1 }, 1) == false);
            Console.WriteLine(CanPlaceFlowers(new[] { 1, 0, 0 }, 0) == true);
            Console.WriteLine(CanPlaceFlowers(new[] { 1, 0, 0 }, 1) == true);
            Console.WriteLine(CanPlaceFlowers(new[] { 0, 1, 0 }, 1) == false);
            Console.WriteLine(CanPlaceFlowers(new[] { 0, 0, 1 }, 1) == true);
            Console.WriteLine(CanPlaceFlowers(new[] { 1, 0, 0 }, 2) == false);
        }
        //You have a long flowerbed in which some of the plots are planted, and some are not.However, flowers cannot be planted in adjacent plots.
        //Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule.
            
        //1 <= flowerbed.length <= 2 * 10^4
        //flowerbed[i] is 0 or 1.
        //There are no two adjacent flowers in flowerbed.
        //0 <= n <= flowerbed.length

        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length && n > 0; i++)
                if (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0)
                    if (flowerbed[i] == 0)
                    {
                        if (i==0 || flowerbed[i - 1] == 0)
                            (flowerbed[i++], n) = (1, n - 1);
                    }
                    else
                        i += 1;
                else
                    i += 2;
            return n == 0;
        }
    }
}
