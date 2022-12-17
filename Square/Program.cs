using System;

namespace Square
{
    internal class Program
    {
        public static bool IsSquare(int n)
        {
            return Math.Sqrt(n) % 1 == 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Sqrt(3)%1);
        }
    }
}
