using System;
using System.Linq;
using System.Collections.Generic;

namespace GetUnique
{
    internal class Program
    {
        public static int GetUnique(IEnumerable<int> numbers) => numbers.GroupBy(x => x).Where(x => x.Count() == 1).First().Key;
        
        static void Main(string[] args)
        {
            Console.WriteLine(GetUnique(new[] { 1, 2, 2, 2 }));
        }
    }
}
