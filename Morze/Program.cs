using System;
using System.Collections.Generic;

namespace Morze
{
    internal class Program
    {
        public static string Decode(string morseCode) //.... . -.--   .--- ..- -.. .
        {

            Dictionary<string, string> morze = new Dictionary<string, string>
            {
                    {".-", "A"},
                    {"-...", "B"},
                    {"-.-.", "C"},
                    {"-..", "D"},
                    {".", "E"},
                    {"..-.", "F"},
                    {"--.", "G"},
                    {"....", "H"},
                    {"..", "I"},
                    {".---", "J"},
                    {"-.-", "K"},
                    {".-..", "L"},
                    {"--", "M"},
                    {"-.", "N"},
                    {"---", "O"},
                    {".--.", "P"},
                    {"--.-", "Q"},
                    {".-.", "R"},
                    {"...", "S"},
                    {"-", "T"},
                    {"..-", "U"},
                    {"...-", "V"},
                    {".--", "W"},
                    {"-..-", "X"},
                    {"-.--", "Y"},
                    {"--..", "Z"},
                    {"−−−−−", "0"},
                    {".−−−−", "1"},
                    {"..−−−", "2"},
                    {"...−−", "3"},
                    {"....−", "4"},
                    {".....", "5"},
                    {"−....", "6"},
                    {"−−...", "7"},
                    {"−−−..", "8"},
                    {"−−−−.", "9"},
                    {" "," "}



            };
            int index = 0;
            List<int> indexes = new List<int>();
            List<string> decodes = new List<string>();
            string [] codes = morseCode.Split(new char[] { ' ' });


            for (int i = 0; i < codes.Length; i++)
            {

                if (string.IsNullOrWhiteSpace(codes[i]))
                {
                    
                    int j = i;

                    if (string.IsNullOrWhiteSpace(codes[j]) && string.IsNullOrWhiteSpace(codes[++j]))
                    {
                        decodes.Add(" ");
                        i += 2;
                    }
                }


                if (!string.IsNullOrWhiteSpace(codes[i]))
                {
                    decodes.Add(codes[i]);                    
                }

            }

            string str = default;
            foreach (var item in decodes)
            {
                if (morze.ContainsKey(item))
                {
                    str+=morze[item];
                }

                
            }

            return str;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Decode(". ."));
        }
    }
}
