
using System;

namespace _100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine($"{i}-2");
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine($"{i}-3");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine($"{i}-5");
                }
            }        
        
        }
    }
}
