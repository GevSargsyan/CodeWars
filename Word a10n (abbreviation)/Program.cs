using System;
using System.Collections.Generic;
using System.Linq;

namespace Word_a10n__abbreviation_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Abbreviate("my. dog, isn't feeling very well.")); 

        }
        public static string Abbreviate(string input)
        {
            string s = input;
            List<int> ind = new List<int>();
            List<int> indexes = new List<int>();

            while (s.IndexOf('-') != -1)
            {
                ind.Add(ind.Count > 0 ? s.IndexOf('-') + 1 + ind.LastOrDefault() : s.IndexOf('-'));
                s = s.Substring(s.IndexOf('-') + 1);
            }
            indexes.AddRange(ind);
            ind.Clear();
            s = input;

            while (s.IndexOf('!') != -1)
            {
                ind.Add(ind.Count > 0 ? s.IndexOf('!') + 1 + ind.LastOrDefault() : s.IndexOf('!'));
                s = s.Substring(s.IndexOf('!') + 1);
            }
            indexes.AddRange(ind);
            ind.Clear();
            s = input;

            while (s.IndexOf('.') != -1)
            {
                ind.Add(ind.Count > 0 ? s.IndexOf('.') + 1 + ind.LastOrDefault() : s.IndexOf('.'));
                s = s.Substring(s.IndexOf('.') + 1);
            }
            indexes.AddRange(ind);
            ind.Clear();
            s = input;

            while (s.IndexOf(',') != -1)
            {
                ind.Add(ind.Count > 0 ? s.IndexOf(',') + 1 + ind.LastOrDefault() : s.IndexOf(','));
                s = s.Substring(s.IndexOf(',') + 1);
            }
            indexes.AddRange(ind);
            ind.Clear();
            s = input;

            while (s.IndexOf((char)39) != -1)
            {
                ind.Add(ind.Count > 0 ? s.IndexOf((char)39) + 1 + ind.LastOrDefault() : s.IndexOf((char)39));
                s = s.Substring(s.IndexOf((char)39) + 1);
            }
            indexes.AddRange(ind);


            foreach (var item in indexes)
            {
                var x = item;
                if (x != indexes.First())
                {
                    x += 2;
                }
                input = input.Insert(x, " ");
                Console.WriteLine(input[x]);
                if (input[x + 1] !=' ')
                {
                    input = input.Insert(x + 2, " ");

                }


            }
            input = input.Trim();
            string[] words = input.Split(new char[] { ' ' });
            string result = "";
            foreach (var item in words)
            {
                if (item == "-" || item == "!")
                {
                    result = result.Remove(result.Length - 1, 1);
                    result += item;
                    continue;
                }
                if (item.Length >= 4)
                {
                    result += item[0] + (item.Length - 2).ToString() + item[item.Length - 1] + " ";
                }
                if (item.Length<4)
                {
                   result += item + " ";
                }


            }
                return result.Trim();
        }

    }
}
