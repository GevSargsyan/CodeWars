using System;
using System.Text.RegularExpressions;

namespace Regexx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^\d+$");
            while (true)
            {
                Console.WriteLine("Enter Number");
                string s = Console.ReadLine();
                Console.WriteLine(regex.IsMatch(s)?"Number":"Not a Number");


            }

        }
    }
}
