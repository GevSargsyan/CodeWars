using System;

namespace Fibonacci
{
    internal class Program
    {
        public static int Fib(int n)
        {
            // 1 1 2 3 5 8 13 21
            int a, b;
            a = 0;
            b = 1;
            for (int i = 1; i < n; i++)
            {
                b = a + b;
                a = b - a;
            }
            return b;

            //if (n == 1 || n == 2)
            //{
            //    return 1;
            //}
            //return Fib(n - 1) + Fib(n - 2);

        }
        static void Main(string[] args)
        {
            Fib(4);
        }

    }
}
