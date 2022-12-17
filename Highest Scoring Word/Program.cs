using System;
using System.Collections.Generic;
using System.Linq;

namespace Highest_Scoring_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(High("man i need a a taxi up to ubud"));
        }

        public static string High(string s)
        {
            var words = s.Split(' ');
            List<(string, int)> keyValuePairs = new List<(string, int)>();
            int sum = 0;
            for (int i = 0; i < words.Length; i++)
            {
                var chars = words[i].ToCharArray();
                sum = 0;
                foreach (var c in chars)
                {
                    sum += (int)c - 96;
                }
                 keyValuePairs.Add((words[i], sum));
            }

          //  var r =  s.Split(' ').OrderBy(a => a.Select(b => b - 96).Sum()).Last();

            return keyValuePairs.FirstOrDefault(x => x.Item2 == keyValuePairs.Select(x => x.Item2).Max()).Item1;


        }
    }
}
