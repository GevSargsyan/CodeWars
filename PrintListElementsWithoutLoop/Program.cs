using System;
using System.Collections.Generic;

namespace PrintListElementsWithoutLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WithoutLoop(new List<string> { "a", "b", "c" }, 0);
        }

        private static void WithoutLoop(List<string> list,int iterator)
        {
            if (iterator == list.Count)
            {
                return;
            }
            Console.WriteLine(list[iterator]);
            WithoutLoop(list,++iterator);
        }

    }
}
