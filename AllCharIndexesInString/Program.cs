using System;
using System.Collections.Generic;
using System.Linq;

namespace AllCharIndexesInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            string s = $"1={(x ? "1" : "0")}";
            string s1 = "abc-abc-abc--a-";
            int count = s1.Where(x => x == '-').Count();
            Console.WriteLine(count);
            string s2 = s1;
            List<int> indexes = new List<int>();
            while (s1.IndexOf('-') != -1)
            {
                indexes.Add(indexes.Count > 0 ? s1.IndexOf('-') + 1 + indexes.LastOrDefault() : s1.IndexOf('-'));
                s1 = s1.Substring(s1.IndexOf('-') + 1);
            }
            indexes.ForEach(x => Console.WriteLine(s2[x]));

        }
    }
}
