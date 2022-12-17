using System;
using System.Collections.Generic;

namespace Fibonacci_N
{
    internal class Program
    {

        public static decimal Fib(int n)
        {
            // 1 1 2 3 5 8 13 21
            decimal a, b;
            a = 0;
            b = 1;
            for (int i = 1; i < n-1; i++)
            {
                b = a + b;
                a = b - a;
            }
            return b;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(100));
        }
    }
}
