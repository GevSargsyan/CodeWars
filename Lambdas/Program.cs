using System;

namespace Lambdas // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
    

            string s = "123s";
            var pl = int.TryParse(s, out var p);
            if (pl)
            {
              Console.WriteLine(p);
            }
            object[] x = new object[] { 10, '2', "30" };
            for (int i = 0; i < x.Length; i++)
            {
                var y = x[i];
                Console.WriteLine(x[i]);

            }

            Func<int, int> cube = x => x * x;
            var d = cube(5);
            Console.WriteLine(d);

            Func<int, string, bool> func = (length, str) => str.Length > length;

            Console.WriteLine(func(5, "abccde"));

            var hello = (int x, int y, int length) =>
            {
                int sum;
                for (int i = 0; i < length; i++)
                {
                    sum = 0;
                    sum += x + y + i;
                    Console.WriteLine(sum);
                }
                return false;

            };

            var r = hello(1, 2, 5);

        }
    }
}