using System;
using System.Collections.Generic;

namespace Smile_Face
{
    internal class Program
    {
        public static int CountSmileys(string[] smileys)
        {
            Dictionary<string, bool> keyValuePairs = new Dictionary<string, bool> ();
            keyValuePairs.Add(":)", true);
            keyValuePairs.Add(":D", true);
            keyValuePairs.Add(";-D", true);
            keyValuePairs.Add(":~)", true);
            keyValuePairs.Add(";(", false);
            keyValuePairs.Add(":>", false);
            keyValuePairs.Add(":}", false);
            keyValuePairs.Add(":}", false);
            return 0;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
