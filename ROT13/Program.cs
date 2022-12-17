using System;
using System.Collections.Generic;
using System.Linq;

namespace ROT13
{
    internal class Program
    {
        //public static string Rot13(string message) => new string(message.Where(x => char.IsLetter(x)).Select(x => char.IsUpper(x) ? (int)x > 77 ? (char)(((int)x + 13 - 26)) : (char)((int)x + 13) : (int)x > 109 ? (char)(((int)x + 13 - 26)) : (char)((int)x + 13)).ToArray());

        public static string Rot13(string message)
        {
            List<char> arr = new List<char>();
            foreach (var item in message)
            {
                if (char.IsLetter(item) && char.IsUpper(item))
                {
                    if ((int)item > 77)
                    {
                        arr.Add((char)(((int)item + 13 - 26)));
                    }
                    else
                    {
                        arr.Add((char)((int)item + 13));
                    }
                }
                else if(char.IsLetter(item))
                {
                    if ((int)item > 109)
                    {
                        arr.Add((char)(((int)item + 13 - 26)));
                    }
                    else
                    {
                        arr.Add((char)((int)item + 13));
                    }
                }
                else
                {
                    arr.Add(item);
                }

            }

            return new string(arr.ToArray());
        }
      
        static void Main(string[] args)
        {
        
            Console.WriteLine(Rot13("Test"));
        }
    }
}
///////////// 85 + 13 - 26  
//////////////// 86 + 13 - 26  