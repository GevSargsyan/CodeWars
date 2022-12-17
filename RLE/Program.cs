using System;
using System.Collections.Generic;
using System.Linq;

namespace RLE // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static string Encode(string s)
        {

            string res = "";
            while (s.Length>0)
            {
                int i = 0;
                if (s.All(x => x == s[i]))
                { 
                    res += $"{s.Count()}{s[i]}";
                    return res;
                }
                else
                {
                    while (s[i] == s[++i]) { }
                    res += $"{i}{s[i - 1]}";
                    s = s.Substring(i);

                }
            }
            return res;

            #region ChishtRLE 
            //xndire uzumer vor hertov tpi aysinqn ("AAABBBCCCA","3A3B3C1A")
            //ste ashxatuma yndhanur vory vor chisht dzevna => ("AAABBBCCCA","4A3B3C")


            //var xz = s.GroupBy(x => x).Select(x => x.Count().ToString() + x.Key);
            //string temp = "";
            //foreach (var item in xz)
            //{
            //    temp += item;
            //}

            //return temp;
            #endregion

        }

        public static string Decode(string s)
        {
            int i = 0;
            string res = "";
            string n = "";
            while (s.Length>0)
            {
                n = "";
                while (Char.IsDigit(s[i]))
                {
                    n += s[i];
                    i++;
                }

                for (int j = 0; j < int.Parse(n); j++)
                {
                    res += s[i];
                }
                s = s.Substring(i + 1);
                i = 0;
            }
            return res;
        }
        public static void Main(string[] args)
        {

            Console.WriteLine(Encode("AAABBBCCCAA"));
            Console.ReadKey();
        }
    }

}