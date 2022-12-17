using System;
using System.Collections.Generic;
using System.Linq;

namespace Agggregate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var nums = new[] { 1, 2, 3, 4 };
            var sum = nums.Aggregate((a, b) => a + b);
            Console.WriteLine(sum);// Output 10

            var chars = new[] { "a", "b", "c", "d" };
            var csv = chars.Aggregate((a, b) => a + ',' + b);
            Console.WriteLine(csv); // Output a,b,c,d

            var mult = nums.Aggregate(10,(a, b) => a * b);
            Console.WriteLine(mult);// Output 240
            //a=seed=10
            //b=a*2
           

            IEnumerable<string> strings = new List<string> { "a", "ab", "abc", "abcd" };
            // Reimplementation of the Count() method utilizing Aggregate()
            // Will return 4
            int result = strings.Aggregate(0, (count, val) =>  count + 1);

            var x = new { Name = "A", Age = 10 };
            Console.WriteLine(x.GetType().GetProperties().Length);

        }
    }
}
