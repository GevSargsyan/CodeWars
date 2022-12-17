using System;
using System.Linq;
namespace Orderr
{
    internal class Program
    {
        public static string Order(string words)
        {
            var trim = words.Split(new char[] { ' ' });
            string res = "";
            for (int i = 0; i < trim.Length; i++)
            {
                res += trim.FirstOrDefault(x => x.Contains((char)(49 + i))) + " ";
            }
            return res.Trim();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Order("is2 Thi1s T4est 3a"));
        }
    }
}
