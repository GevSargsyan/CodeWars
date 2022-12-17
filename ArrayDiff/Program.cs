using System;
using System.Linq;

namespace ArrayDiff
{
    internal class Program
    {
        public static int[] ArrayDiff(int[] a, int[] b) => a.Where(x => !b.Contains(x)).ToArray();
       
        static void Main(string[] args)
        {
            ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 });
        }
    }
}
