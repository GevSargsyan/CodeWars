using System;
using System.Collections.Generic;

namespace Testing_1_2_3
{
    internal class Program
    {
        public static List<string> Number(List<string> lines)
        {
            List<string> returnstring = new List<string>();
            int i = 1;
            lines.ForEach(x => returnstring.Add(i++.ToString() + ": " + x));
            return returnstring;
        }
        static void Main(string[] args)
        {
            var x =(Number(new List<string> { "a", "b", "c" })); 
            x.ForEach(x => Console.WriteLine(x));
        }
    }
}
