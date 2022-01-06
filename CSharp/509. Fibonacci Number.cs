using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public partial class Solution
    {
        public void TestFib()
        {
            Console.WriteLine(Fib(0) == 0);
            Console.WriteLine(Fib(1) == 1);
            Console.WriteLine(Fib(2) == 1);
            Console.WriteLine(Fib(3) == 2);
            Console.WriteLine(Fib(4) == 3);
            Console.WriteLine(Fib(5) == 5);
            Console.WriteLine(Fib(6) == 8);
            Console.WriteLine(Fib(7) == 13);
            Console.WriteLine(Fib(8) == 21);
        }
        //The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, such that each number is the sum of the two preceding ones, starting from 0 and 1. That is,
        //F(0) = 0, F(1) = 1
        //F(n) = F(n - 1) + F(n - 2), for n > 1.
        //Given n, calculate F(n).

        //0 <= n <= 30
        public int Fib(int n)
        {
            if(n == 0)
                return 0;
            else if (n == 1)
                return 1;
            int p = 0;
            int pp = 1;
            for(int i = 1; i < n; i++)
            {
                pp = p + pp;
                p = pp - p;
            }
            return pp;
        }
    }
}