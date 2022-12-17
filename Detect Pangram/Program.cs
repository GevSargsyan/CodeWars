using System;
using System.Collections.Generic;
using System.Linq;

namespace Detect_Pangram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPangram("The quick brown fox jumps over the lazy dog"));

        }

        public static bool IsPangram(string str)
        {

            IEnumerable<char> chars = str.ToLower().Distinct();
            for (int i = 97; i <= 122; i++)
            {
                if (!chars.Contains((char)i))
                {
                    return false;
                }
            }

            return true;

            //return "abcdefghijklmnopqrstuvwxyz".All(x => str.ToLower().Contains(x));
        }
    }
}
