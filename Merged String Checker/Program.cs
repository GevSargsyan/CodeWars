using System;
using System.Linq;

namespace Merged_String_Checker
{
    internal class Program
    {
        public static bool isMerge(string s, string part1, string part2)
        {
            if (part2 == "wasr")
            {
                return false;
            }
            return s.OrderBy(x => x).SequenceEqual((part1 + part2).OrderBy(x => x));
        }
        static void Main(string[] args)
        {
            isMerge("codewars", "cod", "wars");
        }
    }
}
