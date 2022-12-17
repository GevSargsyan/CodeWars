using System;

namespace ParseAndConvertComparer
{
    internal class Program
    {
        static void Comparer()
        {
            int iterations = 1000000;
            string val = "1234";

            Console.Write("Run 1: int.Parse() ");
            DateTime start = DateTime.Now;
            DoParse(iterations, val);
            TimeSpan duration = DateTime.Now - start;
            Console.WriteLine("Duration: " + duration.TotalMilliseconds.ToString() + "ms");

            Console.Write("Run 1: Convert.ToInt32() ");
            start = DateTime.Now;
            DoConvert(iterations, val);
            duration = DateTime.Now - start;
            Console.WriteLine("Duration: " + duration.TotalMilliseconds.ToString() + "ms");

        }
        static void DoParse(int iterations, string val)
        {
            int x;
            for (int i = 0; i < iterations; i++)
            {
                x = int.Parse(val[0].ToString());
            }
        }

        static void DoConvert(int iterations, string val)
        {
            int x;
            for (int i = 0; i < iterations; i++)
            {
                x = Convert.ToInt32(val[0]-48);
            }
        }

        static void Main(string[] args)
        {
           Comparer();
        }
    }
}
