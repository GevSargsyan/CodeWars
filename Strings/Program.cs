using System;
using System.Security.Cryptography;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "3000 >= @GrossReferal heto ba inch ka";

           s = s.Replace("@GrossReferal","Grzo");

            var randomNumber = new byte[32];
            using (var r = RandomNumberGenerator.Create())
            {
                r.GetBytes(randomNumber);
                var x = Convert.ToBase64String(randomNumber);
            }


            Console.ReadKey();




        }
    }
}
