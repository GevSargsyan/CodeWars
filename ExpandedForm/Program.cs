using System;
using System.Collections.Generic;

namespace ExpandedForm
{
    internal class Program
    {

        public static string ExpandedForm(long num)
        {
            string s = num.ToString();
            List<string> list = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '0')
                {
                    string temp = s[i].ToString();
                    for (int j = 0; j < s.Length - i - 1; j++)
                    {
                        temp += "0";
                    }
                    list.Add(temp);
                }
            }
            return string.Join(" + ",list);
        }
        static void Main(string[] args)
        {

            Console.WriteLine(ExpandedForm(12)); 

        }
    }
}
